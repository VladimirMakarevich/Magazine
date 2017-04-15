$(document).ready(function () {
    $("#GetListItems").click(function (e) {
        e.preventDefault();
        var data = new Object();
        var id = $("#Id").val();
        data.id = id;

        $.ajax({
            type: 'GET',
            contentType: 'application/json; charset=utf-8',
            url: '/Magazine/GetListItems',
            data: data,
            success: function (data) {
                $("#result").val(data);
            }
        });
    });
});