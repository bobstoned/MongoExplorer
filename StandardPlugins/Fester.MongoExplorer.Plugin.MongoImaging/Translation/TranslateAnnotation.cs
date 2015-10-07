using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Blithe.Common.Imaging;
using System.Drawing;
using Fester.MongoExplorer.Plugin.MongoImaging.Collections;

namespace Fester.MongoExplorer.Plugin.MongoImaging {

	/// <summary>
	/// Translates imaging annotations to and from a serializable version
	/// for save to a database or file
	/// </summary>
	public class TranslateAnnotation {

		public static List<ImageDoc.Annotation> Translate(List<BlitheImagePage> pages) {
			List<ImageDoc.Annotation> annotations = new List<ImageDoc.Annotation>();
			int pageIndex = 0;
			foreach (BlitheImagePage page in pages) {
				List<ImageDoc.Annotation> pageAnnotations = Translate(page.Changes);
				foreach (ImageDoc.Annotation annotation in pageAnnotations) {
					annotation.PageIndex = pageIndex;
				}
				annotations.AddRange(pageAnnotations);
				pageIndex++;
			}
			return annotations;
		}

		public static List<ImageDoc.Annotation> Translate(List<BaseAnnotation> imagingAnnotations) {
			List<ImageDoc.Annotation> list = new List<ImageDoc.Annotation>();
			foreach (BaseAnnotation annotation in imagingAnnotations) {
				list.Add(Translate(annotation));
			}
			return list;
		}

		public static ImageDoc.Annotation Translate(BaseAnnotation imagingAnnotation) {
			ImageDoc.Annotation annotation = new ImageDoc.Annotation();
			annotation.AnnotationType = AnnotationClassToType(imagingAnnotation).ToString() ;
			annotation.FillColor = ColorToSimpleType(imagingAnnotation.FillColor);
			annotation.FillOpacity = imagingAnnotation.FillOpacity;
			annotation.LineColor = ColorToSimpleType(imagingAnnotation.LineColor);
			annotation.LineThickness = imagingAnnotation.LineThickness;
			//annotation.Outline = imagingAnnotation.Outline;
			annotation.Points = PointsToSimpleType(imagingAnnotation.Points);
			annotation.Rect = RectToSimpleType(imagingAnnotation.Rect);
			if (imagingAnnotation is TextAnnotation) {
				annotation.Text = (imagingAnnotation as TextAnnotation).Text;
				annotation.TextColor = ColorToSimpleType((imagingAnnotation as TextAnnotation).TextColor);
				annotation.Font = new ImageDoc.SimpleFont((imagingAnnotation as TextAnnotation).TextFont);
			}
			
			if (imagingAnnotation is SvgAnnotation) {
				annotation.SvgImageName = (imagingAnnotation as SvgAnnotation).ImageName;
			}
			if (imagingAnnotation is PolygonAnnotation) {
				annotation.SvgImageName = (imagingAnnotation as PolygonAnnotation).ShapeName;
			}
			return annotation;
		}

		private static ImageDoc.ColorType ColorToSimpleType(Color color) {
			ImageDoc.ColorType colorType = new ImageDoc.ColorType(color.R, color.G, color.B);
			return colorType;
		}

		public static AnnotationList Translate(List<ImageDoc.Annotation> annotations, float scale, ColourFormat colourFormat, PointF controlOffset, PointF imageOffset) {
			AnnotationList imagingAnnotations = new AnnotationList();
			foreach (ImageDoc.Annotation annotation in annotations) {
				imagingAnnotations.Add(Translate(annotation, scale, colourFormat, controlOffset, imageOffset));
			}
			return imagingAnnotations;
		}

		public static BaseAnnotation Translate(ImageDoc.Annotation annotation, float scale, ColourFormat colourFormat, PointF controlOffset, PointF imageOffset) {
			BaseAnnotation imagingAnnotation = null;
			ImageDoc.ImagingAnnotationTypes annType = (ImageDoc.ImagingAnnotationTypes)
				Enum.Parse(typeof(ImageDoc.ImagingAnnotationTypes), annotation.AnnotationType);
			switch (annType) {
				case ImageDoc.ImagingAnnotationTypes.FreeLine: {
					imagingAnnotation
						= new FreeLineAnnotation(SimpleTypeToColor(annotation.LineColor), annotation.LineThickness, scale, colourFormat, controlOffset, imageOffset);
					break;

				}
				case ImageDoc.ImagingAnnotationTypes.Highlighter: case ImageDoc.ImagingAnnotationTypes.Polygon: {
					imagingAnnotation = new PolygonAnnotation(SimpleTypeToColor(annotation.LineColor), annotation.LineThickness, scale, colourFormat, controlOffset, imageOffset);
				}
					break;
				case ImageDoc.ImagingAnnotationTypes.Stamp: {
						imagingAnnotation = new StampAnnotation(annotation.LineThickness, scale, colourFormat, controlOffset, imageOffset);
					}
					break;
				case ImageDoc.ImagingAnnotationTypes.StraightLine: {
					imagingAnnotation = new StraightLineAnnotation(SimpleTypeToColor(annotation.LineColor), annotation.LineThickness, scale, colourFormat, controlOffset, imageOffset);
					}
					break;
				case ImageDoc.ImagingAnnotationTypes.TextAnnotation: {
					// Top left of the text
					Point topLeft = new Point((int)annotation.Rect.TopLeft.X, (int)annotation.Rect.TopLeft.Y);
					imagingAnnotation = new TextAnnotation(topLeft, controlOffset, imageOffset, scale, colourFormat);
					}
					break;
				case ImageDoc.ImagingAnnotationTypes.Svg: {
						// Top left of the text
					Point topLeft = new Point((int)annotation.Rect.TopLeft.X, (int)annotation.Rect.TopLeft.Y);
						imagingAnnotation = new SvgAnnotation(topLeft, controlOffset, imageOffset, scale, colourFormat);
						(imagingAnnotation as SvgAnnotation).ImageName = annotation.SvgImageName;
					}
					break;
			}
			if ((imagingAnnotation is PolygonAnnotation)) {
				(imagingAnnotation as PolygonAnnotation).ShapeName = annotation.SvgImageName;
				foreach (ImageDoc.Point point in annotation.Points) {
					Point intPoint = new Point((int)point.X, (int)point.Y);
					(imagingAnnotation as PolygonAnnotation).AddPoint(intPoint);
				}
				// This forces the initialisation of some required objects
				(imagingAnnotation as PolygonAnnotation).EndDrawing();
			}
			if ((imagingAnnotation is StampAnnotation)) {
				foreach (ImageDoc.Point point in annotation.Points) {
					Point intPoint = new Point((int)point.X, (int)point.Y);
					(imagingAnnotation as StampAnnotation).Points.Add(intPoint);
				}
			}
			if ((imagingAnnotation is TextAnnotation)) {
				(imagingAnnotation as TextAnnotation).Text = annotation.Text;
				(imagingAnnotation as TextAnnotation).TextFont = annotation.Font.ToFont();
				(imagingAnnotation as TextAnnotation).TextColor = SimpleTypeToColor(annotation.TextColor);
			}
			imagingAnnotation.Rect = SimpleTypeToRect(annotation.Rect);
			imagingAnnotation.Filled = true;
			imagingAnnotation.FillColor = SimpleTypeToColor(annotation.FillColor);
			imagingAnnotation.FillOpacity = annotation.FillOpacity;
			//imagingAnnotation.Outline = annotation.Outline;
			return imagingAnnotation;
		}

		private static ImageDoc.ImagingAnnotationTypes AnnotationClassToType(BaseAnnotation imagingAnnotation) {
			if (imagingAnnotation is FreeLineAnnotation) return ImageDoc.ImagingAnnotationTypes.FreeLine;
			if (imagingAnnotation is StraightLineAnnotation) return ImageDoc.ImagingAnnotationTypes.StraightLine;
			if (imagingAnnotation is SvgAnnotation) return ImageDoc.ImagingAnnotationTypes.Svg;
			if (imagingAnnotation is TextAnnotation) return ImageDoc.ImagingAnnotationTypes.TextAnnotation;
			if (imagingAnnotation is StampAnnotation) return ImageDoc.ImagingAnnotationTypes.Stamp;
			if (imagingAnnotation is PolygonAnnotation) return ImageDoc.ImagingAnnotationTypes.Polygon;
			if (imagingAnnotation is PolygonAnnotation && imagingAnnotation.FillOpacity == 128)
				return ImageDoc.ImagingAnnotationTypes.Highlighter;
			return ImageDoc.ImagingAnnotationTypes.FreeLine;
		}

		#region Helper Converters

		private static List<ImageDoc.Point> PointsToSimpleType(List<PointF> points) {
			List<ImageDoc.Point> simplePoints = new List<ImageDoc.Point>();
			foreach (PointF point in points) {
				simplePoints.Add(PointToSimpleType(point));
			}
			return simplePoints;
		}

		private static ImageDoc.Point PointToSimpleType(PointF point) {
			ImageDoc.Point simplePoint = new ImageDoc.Point(point.X, point.Y);
			return simplePoint;
		}

		private static ImageDoc.BoundingRect RectToSimpleType(RectangleF rect) {
			ImageDoc.BoundingRect simpleRect = new ImageDoc.BoundingRect();
			simpleRect.TopLeft = PointToSimpleType(new PointF(rect.X, rect.Y));
			simpleRect.Height = rect.Height;
			simpleRect.Width = rect.Width;
			return simpleRect;
		}

		private static Color SimpleTypeToColor(ImageDoc.ColorType colorType) {
			return Color.FromArgb(colorType.R, colorType.G, colorType.B);
		}

		private static PointF SimpleTypeToPoint(ImageDoc.Point colorType) {
			return new PointF(colorType.X, colorType.Y);
		}

		private static RectangleF SimpleTypeToRect(ImageDoc.BoundingRect boundingRect) {
			RectangleF rect = new RectangleF(
				SimpleTypeToPoint(boundingRect.TopLeft),
				new SizeF(boundingRect.Width, boundingRect.Height)
			);
			return rect;
		}


		#endregion



	}
}