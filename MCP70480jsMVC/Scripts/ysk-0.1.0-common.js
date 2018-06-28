$(function() {
    $('#save').on('click', function () {
        $('#uinfos').empty();
        var last = $('#last').val();
        var first = $('#first').val();
        $('#uinfos').text("hello, " + first + " " + last);

        event.preventDefault();
    });
})