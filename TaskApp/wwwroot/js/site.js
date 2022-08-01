// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(function () {
    $.ajax({
        url: '/Task/TasksList',
        type: 'GET',
        cache: false,
    }).done(function (result) {
        $('#taskList').html(result);
    });
});


$(document).on('click', '.btn-close', function (e) {
    var taskId = $(this).attr("data-id");
    console.log('taskId ' + taskId);
    $.ajax({
        type: "Delete",
        url: '/Task/Delete?id=' + taskId,
        contentType: 'application/json; charset=utf-8',
        success: function (data) {
            location.reload();
        },error:function(data) {
            alert("Cannot delete, Something went wrong");
        }
    });
});
