db.image.insert({
	_id: 10,
	name: "Emmy",
	desc: "Emmy on holiday",
    type: "jpeg",
	size: 330000,
	height: 2101,
	width: 1518,
	imageData: '',
	annotations: [
		{
			pageIndex: 1,
			fillOpacity: 255,
			lineColor: {
				r: 0,
				g: 0,
				b: 0
			},
			fillColor: {
				r: 255,
				g: 255,
				b: 255
			},		
			lineThickness: 1,
			filled: false,
			annotationType: "Highlighter",
			rect: {
				topLeft: {x:50, y:50},
				width: 50,
				height: 50
			},
			points: [
				{x: 50, y: 50},
				{x: 100, y: 50},
				{x: 100, y: 100},
				{x: 50, y: 100},				
			],
			text: "A nice rectangle!",
			font: {
				family: "Tahoma",
				size: 9.75,
				color: {
					r: 0,
					g: 0,
					b: 0					
				}
			},
			hasLine: true
		}
	]
})