var navigationData = [
    {
        dashArray: '5,1',
        visible: true,
        angle: -0.8,
        color: 'black',
        latitude: [28.6139391, 39.9041999],
        longitude: [77.2090212, 116.4073963],

    },
    {
        dashArray: '5,1',
        visible: true,
        angle: -0.8,
        color: 'black',
        latitude: [28.6139391, 31.2303904],
        longitude: [77.2090212, 121.4737021],

    },
    {
        dashArray: '5,1',
        visible: true,
        angle: -0.6,
        color: 'black',
        latitude: [28.6139391, 23.12911],
        longitude: [77.2090212, 113.264385],

    },
    {
        dashArray: '5,1',
        visible: true,
        angle: -0.8,
        color: 'black',
        latitude: [28.6139391, 22.396428],
        longitude: [77.2090212, 114.109497],

    },
    {
        dashArray: '5,1',
        visible: true,
        angle: -0.8,
        color: 'black',
        latitude: [19.0759837, 23.12911],
        longitude: [72.8776559, 113.264385],

    },
    {
        dashArray: '5,1',
        visible: true,
        angle: -0.8,
        color: 'black',
        latitude: [13.0826802, 22.396428],
        longitude: [80.2707184, 114.109497],

    },
    {
        dashArray: '5,1',
        visible: true,
        angle: -0.8,
        color: 'black',
        latitude: [22.572646, 24.880095],
        longitude: [88.363895, 102.832891],
    }
];
var penisular_marker = [
    {
        latitude: 22.403410892712124,
        longitude: -97.8717041015625,
        name: 'ALTAMIRA'
    },
    {
        latitude: 29.756032197482973,
        longitude: -95.36270141601562,
        name: 'HOUSTON'
    },
    {
        latitude: 30.180747605060766,
        longitude: -85.81283569335938,
        name: 'PANAMA CITY'
    },
    {
        latitude: 27.9337540167772,
        longitude: -82.49908447265625,
        name: 'TAMPA'
    },
    {
        latitude: 21.282336521195344,
        longitude: -89.6649169921875,
        name: 'PROGRESO'
    }
];
var penisular_location = [
    {
        visible: true,
        latitude: [22.403410892712124, 29.756032197482973],
        longitude: [-97.8717041015625, -95.36270141601562],
        angle: 0,
        dashArray: 1,
        color: 'white',
    },
    {
        visible: true,
        angle: 0,
        color: 'white',
        dashArray: 1,
        latitude: [22.403410892712124, 30.180747605060766 ],
        longitude: [-97.8717041015625, -85.81283569335938]
    },
    {
        dashArray: 1,
        visible: true,
        angle: 0,
        color: 'white',
        latitude: [22.403410892712124, 27.9337540167772],
        longitude: [-97.8717041015625, -82.49908447265625]
    },
    {
        dashArray: 1,
        visible: true,
        angle: 0,
        color: 'white',
        latitude: [22.403410892712124, 21.282336521195344],
        longitude: [-97.8717041015625, -89.6649169921875]
    },
    {
        dashArray: 1,
        visible: true,
        angle: 0,
        color: 'white',
        latitude: [29.756032197482973, 21.282336521195344],
        longitude: [-95.36270141601562, -89.6649169921875]
    },
    {
        dashArray: 1,
        visible: true,
        angle: 0,
        color: 'white',
        latitude: [30.180747605060766, 21.282336521195344],
        longitude: [-85.81283569335938, -89.6649169921875]
    },
    {
        dashArray: 1,
        visible: true,
        angle: 0,
        color: 'white',
        latitude: [27.9337540167772, 21.282336521195344],
        longitude: [-82.49908447265625, -89.6649169921875]
    }
]

var penisularMarker = [
                    {
                        visible: true,
                        shape: 'Circle',
                        fill: 'white',
                        width: 10,
                        height: 10,
                        dataSource: penisular_marker
                    },
                    {
                        visible: true,
                        template: '<div id="marker1" style="font-size: 12px;color:white">ALTAMIRA' +
                            '</div>',
                        dataSource: [
                            { latitude: 22.403410892712124, longitude: -97.8717041015625, }
                        ],
                        animationDuration: 0,
                        offset: {
                            x: -35,
                            y: 0
                        }
                    },
                    {
                        visible: true,
                        template: '<div id="marker2" style="font-size: 12px;color:white">HOUSTON' +
                            '</div>',
                        dataSource: [
                            { latitude: 29.756032197482973, longitude: -95.36270141601562 }
                        ],
                        animationDuration: 0,
                        offset: {
                            x: 0,
                            y: -15
                        }
                    },
                    {
                        visible: true,
                        template: '<div id="marker3" style="font-size: 12px;color:white">PANAMA CITY' +
                            '</div>',
                        dataSource: [
                            { latitude: 30.180747605060766, longitude: -85.81283569335938 }
                        ],
                        animationDuration: 0,
                        offset: {
                            x: 0,
                            y: -5
                        }
                    },
                    {
                        visible: true,
                        template: '<div id="marker4" style="font-size: 12px;color:white">TAMPA' +
                            '</div>',
                        dataSource: [
                            { latitude: 27.9337540167772, longitude: -82.49908447265625 }
                        ],
                        animationDuration: 0,
                        offset: {
                            x: 0,
                            y: -15
                        }
                    },
                    {
                        visible: true,
                        template: '<div id="marker5" style="font-size: 12px;color:white">PROGRESO' +
                            '</div>',
                        dataSource: [
                            { latitude: 21.282336521195344, longitude: -89.6649169921875 }
                        ],
                        animationDuration: 0,
                        offset: {
                            x: 0,
                            y: 15
                        }
                    }
];