google.charts.load('current', { 'packages': ['corechart'] });
google.charts.setOnLoadCallback(generateChart);

function generateChart() {
    pieChart();
    barChart();
}

function barChart() {
    var barChart = $('#barchart');
    var dataUrl = barChart.data('dataurl');
    $.post(dataUrl, function (d) {
        var data = google.visualization.arrayToDataTable(d);
        var chart = new google.visualization.BarChart(barChart[0]);

        var options = {
            'title': 'Sales per Representative',
            'width': 600,
            'height': 300
        };
        chart.draw(data,options);
    });
}


function pieChart() {
    var data = new google.visualization.DataTable();
    data.addColumn('string', 'Products');
    data.addColumn('number', 'Sales');
    data.addRows([
      ['Tofu', 1230],
      ['Chai', 100],
      ['Chocolade', 526],
      ['Ipoh Coffee', 458]
    ]);

    var options = {
        'title': 'Quarterly Sales',
        'width': 600,
        'height': 300,
        is3D: true,
        colors: ['#d9534f', '#f0ad4e', '#5bc0de', '#5cb85c']
    };

    var chart = new google.visualization.PieChart($('#piechart')[0]);
    chart.draw(data, options);
}
