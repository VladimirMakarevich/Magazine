//$(document).ready(function () {

//$("#GetListItems").click(function (e) {
//    e.preventDefault();
//    var data = new Object();
//    var id = $("#Id").val();
//    data.id = id;

//    $.ajax({
//        type: 'GET',
//        contentType: 'application/json; charset=utf-8',
//        url: '/Magazine/GetListItems',
//        data: data,
//        success: function (data) {
//            for (var i = 0; i < data.length; i++) {
//                tr = $("<tr/>");
//                tr.append("<td>" + data[i].Name + "</td>");
//                tr.append("<td>" + data[i].Description + "</td>");
//                $("table.table-bordered.items").append(tr);
//            }
//        }
//    });
//});
//};

//function itemsTable(container) {

//    function locate() {

//        $("itemTable").hide();
//    }

//    return ({
//        init: function () {

//            locate();
//        },
//    })
//};

//var ItemsList = itemsTable(".manageProject");
//ItemsList.init();

function sentData(item) {

    clearTable();
    removeHidden();

    var data = new Object();
    var id = item;
    data.id = id;

    $.ajax({
        type: 'GET',
        contentType: 'application/json; charset=utf-8',
        url: '/Magazine/GetListItems',
        data: data,
        success: function (data) {
            getTable(data);
        }
    });
};

function clearTable() {

    $("table.table-bordered.items").find("tbody").empty();
};

function removeHidden() {
    $(function () {
        $('#itemTable').removeClass('hidden');
    });
}

function getTable(data) {
    for (var i = 0; i < data.length; i++) {
        tr = $("<tr/>");
        tr.append("<td>" + data[i].Name + "</td>");
        tr.append("<td>" + data[i].Description + "</td>");
        $("table.table-bordered.items").append(tr);
    }
}