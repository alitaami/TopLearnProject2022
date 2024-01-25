'use strict';
$(document).ready(function () {
	
	Chart.defaults.global.defaultFontFamily = '"primary-font", "segoe ui", "tahoma"';

    var chartColors = {
        primary: {
            base: '#3f51b5',
            light: '#c0c5e4'
        },
        danger: {
            base: '#f2125e',
            light: '#fcd0df'
        },
        success: {
            base: '#0acf97',
            light: '#cef5ea'
        },
        warning: {
            base: '#ff8300',
            light: '#ffe6cc'
        },
        info: {
            base: '#00bcd4',
            light: '#e1efff'
        },
        dark: '#37474f',
        facebook: '#3b5998',
        twitter: '#55acee',
        linkedin: '#0077b5',
        instagram: '#517fa4',
        whatsapp: '#25D366',
        dribbble: '#ea4c89',
        google: '#DB4437',
        borderColor: '#e8e8e8',
        fontColor: '#999'
    };

    if ($('body').hasClass('dark')) {
        chartColors.borderColor = 'rgba(255, 255, 255, .1)';
        chartColors.fontColor = 'rgba(255, 255, 255, .4)';
    }


    function sparkline_mode1() {
        if ($(".sparkline-demo1").length) {
            $(".sparkline-demo1").sparkline([9, 6, 8, 9, 4, 6, 3, 6, 9, 4, 7, 4, 7], {
                width: '100%',
                height: 100,
                type: 'line',
                fillColor: $('body').hasClass('dark') ? chartColors.primary.base : chartColors.primary.light,
                spotColor: false,
                minSpotColor: false,
                maxSpotColor: false,
                lineColor: chartColors.primary.base,
                lineWidth: 1
            });
        }
    }

    function sparkline_mode2() {
        if ($(".sparkline-demo2").length) {
            $(".sparkline-demo2").sparkline([5, 4, 8, 3, 4, 5, 3, 5, 9, 4, 7, 4, 2], {
                width: '100%',
                height: 100,
                type: 'line',
                fillColor: $('body').hasClass('dark') ? chartColors.danger.base : chartColors.danger.light,
                lineColor: chartColors.danger.base,
                spotColor: false,
                minSpotColor: false,
                maxSpotColor: false,
                lineWidth: 1
            });
        }
    }

    function sparkline_mode3() {
        if ($(".sparkline-demo3").length) {
            $(".sparkline-demo3").sparkline([9, 6, 3, 9, 4, 5, 3, 6, 9, 4, 7, 4, 7], {
                width: '100%',
                height: 100,
                type: 'line',
                fillColor: $('body').hasClass('dark') ? chartColors.success.base : chartColors.success.light,
                lineColor: chartColors.success.base,
                spotColor: false,
                minSpotColor: false,
                maxSpotColor: false,
                lineWidth: 1
            });
        }
    }

    function sparkline_mode4() {
        if ($(".sparkline-demo4").length) {
            $(".sparkline-demo4").sparkline([9, 6, 8, 9, 4, 5, 3, 6, 9, 4, 7, 4, 7], {
                width: '100%',
                height: 100,
                type: 'line',
                fillColor: $('body').hasClass('dark') ? chartColors.warning.base : chartColors.warning.light,
                lineColor: chartColors.warning.base,
                spotColor: false,
                minSpotColor: false,
                maxSpotColor: false,
                lineWidth: 1
            });
        }
    }

    function chart_func_run() {
        sparkline_mode1();
        sparkline_mode2();
        sparkline_mode3();
        sparkline_mode4();
    }

    $(window).on('resize', chart_func_run());

    chart_demo_1();

    chart_demo_2();

    chart_demo_3();

    chart_demo_4();

    chart_demo_5();

    chart_demo_6();

    chart_demo_7();

    chart_demo_8();

    chart_demo_9();

    chart_demo_10();

    function chart_demo_1() {
        if ($('#chart_demo_1').length) {
            var ctx = document.getElementById("chart_demo_1").getContext("2d");
            var gradient = ctx.createLinearGradient(0, 0, 0, 500);
            gradient.addColorStop(0, chartColors.primary.base);
            gradient.addColorStop(1, chartColors.primary.light);
            var gradient2 = ctx.createLinearGradient(0, 0, 0, 500);
            gradient2.addColorStop(0, chartColors.success.base);
            gradient2.addColorStop(1, chartColors.success.light);
            new Chart(ctx, {
                type: 'line',
                data: {
                    labels: ["فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر"],
                    datasets: [{
                        backgroundColor: gradient,
                        label: "دسکتاپ",
                        data: [31, 74, 6, 39, 20, 85, 7],
                        pointRadius: 5,
                        borderWidth: 0
                    }, {
                        backgroundColor: gradient2,
                        label: "موبایل",
                        data: [82, 23, 66, 9, 99, 4, 50],
                        pointRadius: 5,
                        borderWidth: 0
                    }]
                },
                options: {
                    legend: {
                        labels: {
                            fontColor: chartColors.fontColor
                        }
                    },
                    responsive: true,
                    maintainAspectRatio: true,
                    scales: {
                        xAxes: [{
                            gridLines: {
                                color: chartColors.borderColor
                            },
                            ticks: {
                                fontColor: chartColors.fontColor
                            }
                        }],
                        yAxes: [{
                            gridLines: {
                                color: chartColors.borderColor
                            },
                            ticks: {
                                fontColor: chartColors.fontColor,
                                beginAtZero: true
                            }
                        }]
                    },
                    elements: {
                        point: {
                            radius: 3
                        }
                    },
                    layout: {
                        padding: {
                            left: 0,
                            right: 0,
                            top: 0,
                            bottom: 0
                        }
                    },
                    stepsize: 1
                }
            });
        }
    }

    function chart_demo_2() {
        if ($('#chart_demo_2').length) {
            var ctx = document.getElementById('chart_demo_2').getContext('2d');
            new Chart(ctx, {
                type: 'line',
                data: {
                    labels: ["فروردین 1397", "اردیبهشت 1397", "خرداد 1397", "تیر 1397", "مرداد 1397", "شهریور 1397", "مهر 1397", "آبان 1397", "آذر 1397", "دی 1397", "بهمن 1397", "اسفند 1397"],
                    datasets: [{
                        label: "بارش باران",
                        backgroundColor: chartColors.primary.light,
                        borderColor: chartColors.primary.base,
                        data: [26.4, 39.8, 66.8, 66.4, 40.6, 55.2, 77.4, 69.8, 57.8, 76, 110.8, 142.6],
                    }]
                },
                options: {
                    legend: {
                        display: false,
                        labels: {
                            fontColor: chartColors.fontColor
                        }
                    },
                    title: {
                        display: true,
                        text: 'میزان بارش در تبریز',
                        fontColor: chartColors.fontColor,
                    },
                    scales: {
                        yAxes: [{
                            gridLines: {
                                color: chartColors.borderColor
                            },
                            ticks: {
                                fontColor: chartColors.fontColor,
                                beginAtZero: true
                            },
                            scaleLabel: {
                                display: true,
                                labelString: 'میزان بارش بر اساس میلی متر',
                                fontColor: chartColors.fontColor,
                            }
                        }],
                        xAxes: [{
                            gridLines: {
                                color: chartColors.borderColor
                            },
                            ticks: {
                                fontColor: chartColors.fontColor,
                                beginAtZero: true
                            }
                        }]
                    }
                }
            });
        }
    }

    function chart_demo_3() {
        if ($('#chart_demo_3').length) {
            var ctx = document.getElementById("chart_demo_3").getContext("2d");
            new Chart(ctx, {
                type: 'line',
                data: {
                    labels: ['فروردین', 'اردیبهشت', 'خرداد', 'تیر', 'مرداد', 'شهریور', 'مهر'],
                    datasets: [{
                        label: 'اولیه',
                        backgroundColor: chartColors.primary.light,
                        borderColor: chartColors.primary.base,
                        data: [-20, 30, -20, 0, 25, 44, 30],
                        pointRadius: 5,
                        pointHoverRadius: 7,
                        borderDash: [2, 2],
                        fill: false
                    }, {
                        label: 'موفقیت',
                        fill: false,
                        backgroundColor: chartColors.success.light,
                        borderDash: [2, 2],
                        borderColor: chartColors.success.base,
                        data: [30, 33, 22, 39, -30, 19, -37],
                        pointRadius: 5,
                        pointHoverRadius: 7
                    }]
                },
                options: {
                    responsive: true,
                    legend: {
                        labels: {
                            fontColor: chartColors.fontColor
                        }
                    },
                    title: {
                        display: false,
                        fontColor: chartColors.fontColor
                    },
                    scales: {
                        xAxes: [{
                            gridLines: {
                                color: chartColors.borderColor
                            },
                            ticks: {
                                fontColor: chartColors.fontColor
                            }
                        }],
                        yAxes: [{
                            gridLines: {
                                color: chartColors.borderColor
                            },
                            ticks: {
                                fontColor: chartColors.fontColor,
                                min: -50,
                                max: 50
                            }
                        }]
                    }
                }
            });

        }
    }

    function chart_demo_4() {
        if ($('#chart_demo_4').length) {
            var ctx = document.getElementById("chart_demo_4").getContext("2d");
            var densityData = {
                backgroundColor: chartColors.primary.light,
                data: [10, 20, 40, 60, 80, 40, 60, 80, 40, 80, 20, 59]
            };
            new Chart(ctx, {
                type: 'bar',
                data: {
                    labels: ["فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند"],
                    datasets: [densityData]
                },
                options: {
                    scaleFontColor: "#FFFFFF",
                    legend: {
                        display: false,
                        labels: {
                            fontColor: chartColors.fontColor
                        }
                    },
                    scales: {
                        xAxes: [{
                            gridLines: {
                                color: chartColors.borderColor
                            },
                            ticks: {
                                fontColor: chartColors.fontColor
                            }
                        }],
                        yAxes: [{
                            gridLines: {
                                color: chartColors.borderColor
                            },
                            ticks: {
                                fontColor: chartColors.fontColor,
                                min: 0,
                                max: 100,
                                beginAtZero: true
                            }
                        }]
                    }
                }
            });
        }
    }

    function chart_demo_5() {
        if ($('#chart_demo_5').length) {
            var ctx = document.getElementById('chart_demo_5').getContext('2d');
            window.myBar = new Chart(ctx, {
                type: 'bar',
                data: {
                    labels: ['فروردین', 'اردیبهشت', 'خرداد', 'تیر', 'مرداد'],
                    datasets: [
                        {
                            label: 'مجموعه داده 1',
                            backgroundColor: [
                                chartColors.info.base,
                                chartColors.success.base,
                                chartColors.danger.base,
                                chartColors.dark,
                                chartColors.warning.base,
                            ],
                            yAxisID: 'y-axis-1',
                            data: [33, 56, -40, 25, 45]
                        },
                        {
                            label: 'مجموعه داده 2',
                            backgroundColor: chartColors.info.base,
                            yAxisID: 'y-axis-2',
                            data: [23, 86, -40, 5, 45]
                        }
                    ]
                },
                options: {
                    legend: {
                        labels: {
                            fontColor: chartColors.fontColor
                        }
                    },
                    responsive: true,
                    title: {
                        display: true,
                        text: 'Chart.js نمودار میله ای - چند جهت',
                        fontColor: chartColors.fontColor
                    },
                    tooltips: {
                        mode: 'index',
                        intersect: true
                    },
                    scales: {
                        xAxes: [{
                            gridLines: {
                                color: chartColors.borderColor
                            },
                            ticks: {
                                fontColor: chartColors.fontColor
                            }
                        }],
                        yAxes: [
                            {
                                type: 'linear',
                                display: true,
                                position: 'left',
                                id: 'y-axis-1',
                            },
                            {
                                gridLines: {
                                    color: chartColors.borderColor
                                },
                                ticks: {
                                    fontColor: chartColors.fontColor
                                }
                            },
                            {
                                type: 'linear',
                                display: true,
                                position: 'right',
                                id: 'y-axis-2',
                                gridLines: {
                                    drawOnChartArea: false
                                },
                                ticks: {
                                    fontColor: chartColors.fontColor
                                }
                            }
                        ],
                    }
                }
            });
        }
    }

    function chart_demo_6() {
        if ($('#chart_demo_6').length) {
            var ctx = document.getElementById("chart_demo_6").getContext("2d");
            var speedData = {
                labels: ["0s", "10s", "20s", "30s", "40s", "50s", "60s"],
                datasets: [{
                    label: "سرعت اتومبیل (mph)",
                    borderColor: chartColors.primary.base,
                    backgroundColor: 'rgba(0, 0, 0, 0',
                    data: [0, 59, 75, 20, 20, 55, 40]
                }]
            };
            var chartOptions = {
                legend: {
                    scaleFontColor: "#FFFFFF",
                    position: 'top',
                    labels: {
                        fontColor: chartColors.fontColor
                    }
                },
                scales: {
                    xAxes: [{
                        gridLines: {
                            color: chartColors.borderColor
                        },
                        ticks: {
                            fontColor: chartColors.fontColor
                        }
                    }],
                    yAxes: [{
                        gridLines: {
                            color: chartColors.borderColor
                        },
                        ticks: {
                            fontColor: chartColors.fontColor
                        }
                    }]
                }
            };
            new Chart(ctx, {
                type: 'line',
                data: speedData,
                options: chartOptions
            });
        }
    }

    function chart_demo_7() {
        if ($('#chart_demo_7').length) {
            var ctx = document.getElementById("chart_demo_7").getContext("2d");
            new Chart(ctx, {
                type: 'doughnut',
                data: {
                    datasets: [{
                        data: [15, 25, 10, 30, 10],
                        backgroundColor: [
                            chartColors.facebook,
                            chartColors.twitter,
                            chartColors.google,
                            chartColors.instagram,
                            chartColors.whatsapp
                        ],
                        label: 'مجموعه داده 1'
                    }],
                    labels: [
                        'فیسبوک',
                        'توییتر',
                        'گوگل',
                        'اینستاگرام',
                        'واتساپ'
                    ]
                },
                options: {
                    elements: {
                        arc: {
                            borderWidth: 0
                        }
                    },
                    responsive: true,
                    legend: {
                        display: false
                    },
                    title: {
                        display: false
                    },
                    animation: {
                        animateScale: true,
                        animateRotate: true
                    }
                }
            });
        }
    }

    function chart_demo_8() {
        if ($('#chart_demo_8').length) {
            new Chart(document.getElementById("chart_demo_8"), {
                type: 'radar',
                data: {
                    labels: ["آفریقا", "آسیا", "اروپا", "آمریکای لاتین", "آمریکای شمالی"],
                    datasets: [
                        {
                            label: "1950",
                            fill: true,
                            backgroundColor: "rgba(179,181,198,0.2)",
                            borderColor: "rgba(179,181,198,1)",
                            pointBorderColor: "#fff",
                            pointBackgroundColor: "rgba(179,181,198,1)",
                            data: [-8.77, -55.61, 21.69, 6.62, 6.82]
                        }, {
                            label: "2050",
                            fill: true,
                            backgroundColor: "rgba(255,99,132,0.2)",
                            borderColor: "rgba(255,99,132,1)",
                            pointBorderColor: "#fff",
                            pointBackgroundColor: "rgba(255,99,132,1)",
                            data: [-25.48, 54.16, 7.61, 8.06, 4.45]
                        }
                    ]
                },
                options: {
                    legend: {
                        labels: {
                            fontColor: chartColors.fontColor
                        }
                    },
                    scale: {
                        gridLines: {
                            color: chartColors.borderColor
                        }
                    },
                    title: {
                        display: true,
                        text: 'توزیع جمعیت جهان بر اساس درصد',
                        fontColor: chartColors.fontColor
                    }
                }
            });
        }
    }

    function chart_demo_9() {
        if ($('#chart_demo_9').length) {
            new Chart(document.getElementById("chart_demo_9"), {
                type: 'horizontalBar',
                data: {
					labels: ["آفریقا", "آسیا", "اروپا", "آمریکای لاتین", "آمریکای شمالی"],
                    datasets: [
                        {
                            label: "جمعیت (میلیون)",
                            backgroundColor: [chartColors.primary.base, chartColors.success.base, chartColors.info.base, chartColors.warning.base, chartColors.danger.base],
                            data: [2478, 5267, 734, 784, 433]
                        }
                    ]
                },
                options: {
                    legend: {
                        display: false
                    },
                    title: {
                        display: true,
                        text: 'جمعیت پیش بینی شده جهان (میلیون) در سال 2050',
                        fontColor: chartColors.fontColor
                    },
                    scales: {
                        xAxes: [{
                            gridLines: {
                                color: chartColors.borderColor
                            },
                            ticks: {
                                fontColor: chartColors.fontColor
                            }
                        }],
                        yAxes: [{
                            gridLines: {
                                color: chartColors.borderColor
                            },
                            ticks: {
                                fontColor: chartColors.fontColor
                            }
                        }]
                    }
                }
            });
        }
    }

    function chart_demo_10() {
        if ($('#chart_demo_10').length) {
            new Chart(document.getElementById("chart_demo_10"), {
                type: 'bar',
                data: {
                    labels: ["1900", "1950", "1999", "2050"],
                    datasets: [
                        {
                            label: "اروپا",
                            type: "line",
                            borderColor: "#8e5ea2",
                            data: [408, 547, 675, 734],
                            fill: false
                        },
                        {
                            label: "آفریقا",
                            type: "line",
                            borderColor: "#3e95cd",
                            data: [133, 221, 783, 2478],
                            fill: false
                        },
                        {
                            label: "اروپا",
                            type: "bar",
                            backgroundColor: chartColors.primary.base,
                            data: [408, 547, 675, 734],
                        },
                        {
                            label: "آفریقا",
                            type: "bar",
                            backgroundColor: chartColors.primary.light,
                            data: [133, 221, 783, 2478]
                        }
                    ]
                },
                options: {
                    title: {
                        display: true,
                        text: 'رشد جمعیت (میلیون): اروپا و آفریقا',
                        fontColor: chartColors.fontColor
                    },
                    legend: {
                        display: true,
                        labels: {
                            fontColor: chartColors.fontColor
                        }
                    },
                    scales: {
                        xAxes: [{
                            gridLines: {
                                color: chartColors.borderColor
                            },
                            ticks: {
                                fontColor: chartColors.fontColor
                            }
                        }],
                        yAxes: [{
                            gridLines: {
                                color: chartColors.borderColor
                            },
                            ticks: {
                                fontColor: chartColors.fontColor
                            }
                        }]
                    }
                }
            });
        }
    }

    function comments_chart_demo() {
        if ($('#comments_chart_demo').length) {
            var ctx = document.getElementById("comments_chart_demo").getContext("2d");
            var speedData = {
                labels: ["0s", "10s", "20s", "30s", "40s", "50s", "60s"],
                datasets: [{
                    label: "سرعت اتومبیل (mph)",
                    borderColor: 'white',
                    backgroundColor: 'rgba(0, 0, 0, 0',
                    data: [0, 59, 75, 20, 20, 55, 40]
                }]
            };
            var chartOptions = {
                legend: {
                    scaleFontColor: "#FFFFFF",
                    display: false,
                    position: 'top',
                    labels: {
                        boxWidth: 80,
                        fontColor: 'black'
                    }
                },
                scales: {
                    xAxes: [{
                        gridLines: {
                            color: 'rgba(255, 255, 255, .2)'
                        },
                        ticks: {
                            fontColor: 'rgba(255, 255, 255, .7)'
                        }
                    }],
                    yAxes: [{
                        gridLines: {
                            color: 'rgba(255, 255, 255, .2)'
                        },
                        ticks: {
                            fontColor: 'rgba(255, 255, 255, .7)'
                        }
                    }]
                }
            };
            new Chart(ctx, {
                type: 'line',
                data: speedData,
                options: chartOptions
            });
        }
    }

    comments_chart_demo();

    if ($('#circle-1').length) {
        $('#circle-1').circleProgress({
            startAngle: 1.55,
            value: 0.65,
            size: 90,
            fill: {
                color: chartColors.success.base
            }
        });
    }

    if ($('#circle-2').length) {
        $('#circle-2').circleProgress({
            startAngle: 1.55,
            value: 0.35,
            size: 90,
            fill: {
                color: chartColors.danger.base
            }
        });
    }

});