using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fester.MongoExplorer.Plugin.MongoImaging.Collections {

	// This attribute will prevent exceptions being raised when unmapped data
	// is encountered in the document
	[BsonIgnoreExtraElements]
	public class ImageDoc {

		[BsonElement("id")]
		public int Id { get; set; }

		[BsonElement("name")]
		public string Name { get; set; }

		[BsonElement("annotations")]
		public List<Annotation> Annotations { get; set; }

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
			public int lineThickness { get; set; }
			[BsonElement("filled")]
			public bool Filled { get; set; }
			[BsonElement("annotationType")]
			public string AnnotationType { get; set; }
			[BsonElement("rect")]
			public BoundingRect Rect { get; set; }
			[BsonElement("points")]
			public List<Point> Points { get; set; }
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
			public int X { get; set; }
			[BsonElement("y")]
			public int Y { get; set; }

			public Point() {
			}

			public Point(int x, int y) {
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
			public int Width {get; set;}
			[BsonElement("height")]
			public int Height {get; set;}

		}


	}

}
