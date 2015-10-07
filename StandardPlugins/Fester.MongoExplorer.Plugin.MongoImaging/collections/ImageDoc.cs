using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fester.MongoExplorer.Plugin.MongoImaging.Collections {

	// This attribute will prevent exceptions being raised when unmapped data
	// is encountered in the document
	[BsonIgnoreExtraElements]
	public class ImageDoc {

		public ImageDoc() {
			Annotations = new List<Annotation>();
		}

		private ObjectId id = ObjectId.GenerateNewId();

		/// <summary>
		/// Setting the value in code on creation (above). 
		/// Rather use the definition commented out below
		/// but "[BsonIgnoreIfDefault]" never works, tried everything!
		/// </summary>
		[BsonId]
		public ObjectId Id {
			get {
				return id;
			}
			set {
				id = value;
			}
		}

		/*
		[BsonId]
		[BsonIgnoreIfDefault]
		public ObjectId Id {
			get;
			set;
		}
		*/

		[BsonElement("name")]
		public string Name { get; set; }

		[BsonElement("imageData")]
		public string ImageData { get; set; }

		/// <summary>
		/// image size in bytes
		/// </summary>
		[BsonElement("size")]
		public long Size { get; set; }

		[BsonElement("width")]
		public int Width { get; set; }

		[BsonElement("height")]
		public int Height { get; set; }

		[BsonElement("annotations")]
		public List<Annotation> Annotations { get; set; }

		/// <summary>
		/// Get the dimensions of the image as a text string
		/// </summary>
		[BsonIgnore]
		public string DimensionsDisplayText {
			get {
				return string.Format("{0} x {1}", this.Width, this.Height);
			}
		}


		[BsonIgnoreExtraElements]
		public class Annotation {
			public Annotation() {
			}
			[BsonElement("pageIndex")]
			public int PageIndex { get; set; }
			[BsonElement("fillOpacity")]
			public int FillOpacity { get; set; }
			[BsonElement("lineColor")]
			public ColorType LineColor { get; set; }
			[BsonElement("fillColor")]
			public ColorType FillColor { get; set; }
			[BsonElement("lineThickness")]
			public int LineThickness { get; set; }
			[BsonElement("filled")]
			public bool Filled { get; set; }
			[BsonElement("annotationType")]
			public string AnnotationType { get; set; }
			[BsonElement("rect")]
			public BoundingRect Rect { get; set; }
			[BsonElement("points")]
			public List<Point> Points { get; set; }
			[BsonElement("svgImageName")]
			public string SvgImageName { get; set; }
			[BsonElement("text")]
			public string Text { get; set; }
			[BsonElement("font")]
			public SimpleFont Font { get; set; }
			[BsonElement("textColor")]
			public ColorType TextColor { get; set; }
		}

		public class ColorType {
			[BsonElement("r")]
			public int R {get; set;}
			[BsonElement("g")]
			public int G {get; set;}
			[BsonElement("b")]
			public int B {get; set;}

			public ColorType() {
			}

			public ColorType(int r, int g, int b) {
				R = r;
				G = g;
				B = b;
			}
		}

		public class Point {
			[BsonElement("x")]
			public float X { get; set; }
			[BsonElement("y")]
			public float Y { get; set; }

			public Point() {
			}

			public Point(float x, float y) {
				X = x;
				Y = y;
			}
		}


		public class BoundingRect {

			public BoundingRect() {
			}

			[BsonElement("topLeft")]
			public Point TopLeft {get; set;}
			[BsonElement("width")]
			public float Width { get; set; }
			[BsonElement("height")]
			public float Height { get; set; }

		}

		/// <summary>
		/// Al l possible types of annotation
		/// </summary>
		public enum ImagingAnnotationTypes {
			FreeLine,
			Polygon,
			Svg,
			Highlighter,
			StraightLine,
			TextAnnotation,
			Stamp
		}

		// This is proxy structure to enable the serialization of the Font property
		public class SimpleFont {
			public string Family;
			public string Units;
			public float Size;
			public string Style;

			public SimpleFont() {

			}

			public SimpleFont(Font f) {
				Family = f.FontFamily.Name;
				Units = f.Unit.ToString();
				Size = f.Size;
				Style = f.Style.ToString();
			}
			public Font ToFont() {
				FontStyle style = (FontStyle)Enum.Parse(typeof(FontStyle), Style);
				GraphicsUnit units = (GraphicsUnit)Enum.Parse(typeof(GraphicsUnit), Units);
				Font font = new Font(new FontFamily(Family), Size, style, units);
				return font;
			}
		}

		public class ImageFilter {

			string name;
			int width;
			int height;
			long size;

			public string Name {
				get { return name; }
				set { name = value; }
			}

			public int Width {
				get { return width; }
				set { width = value; }
			}

			public int Height {
				get { return height; }
				set { height = value; }
			}

			public long Size {
				get { return size; }
				set { size = value; }
			}

		}


	}

}
