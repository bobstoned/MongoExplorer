db.image.insert({
    _id: 11,
    name: "Emmy",
    desc: "Emmy on holiday",
    type: "jpeg",
    size: NumberInt(330000),
    height: NumberInt(2101),
    width: NumberInt(1518),
    imageData: '',
    annotations: [
		{
		    pageIndex: NumberInt(1),
		    fillOpacity: 255,
		    lineColor: {
		        r: NumberInt(0),
		        g: NumberInt(0),
		        b: NumberInt(0)
		    },
		    fillColor: {
		        r: NumberInt(255),
		        g: NumberInt(255),
		        b: NumberInt(255)
		    },
		    lineThickness: 1,
		    filled: false,
		    annotationType: "highlight",
		    rect: {
		        topLeft: { x: NumberInt(50), y: NumberInt(50) },
		        width: NumberInt(50),
		        height: NumberInt(50)
		    },
		    points: [
				{ x: NumberInt(50), y: NumberInt(50) },
				{ x: NumberInt(100), y: NumberInt(50) },
				{ x: NumberInt(100), y: NumberInt(100) },
				{ x: NumberInt(50), y: NumberInt(100) },
		    ],
		    text: "A nice rectangle!",
		    font: {
		        family: "Tahoma",
		        size: 9.75,
		        color: {
		            r: NumberInt(0),
		            g: NumberInt(0),
		            b: NumberInt(0)
		        }
		    },
		    hasLine: true
		}
    ]
})