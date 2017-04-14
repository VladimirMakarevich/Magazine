$(document).ready(function () {
    $("#GetListItems").click(function (e) {
        e.preventDefault();
        var data = new Object();
        var id = $("#Id").val();
        data.id = id;
        var json = JSON.stringify(data);

        $.ajax({
            type: 'GET',
            contentType: 'application/json; charset=utf-8',
            url: '/Magazine/GetListItems',
            data: json,
            success: function (data) {
                $("#Login").val(data.result);
            }
        });
    });
});