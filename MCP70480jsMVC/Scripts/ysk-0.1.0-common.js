$(function() {
    $('#save').on('click', function () {
        $('#uinfos').empty();
        var last = $('#last').val();
        var first = $('#first').val();
        $('#uinfos').text("hello, " + first + " " + last);

        checkPhoneNumber();

        event.preventDefault();
    });

    function checkPhoneNumber() {
        console.log("check phone number");
        var rgx = new RegExp(/^1?[\s\(-]\d{3}[\s\)-]?\d{3}[\s)-]?\d{4}$/);
        console.log(`rgx.test('1-800-555-6677') is ${rgx.test('1-800-555-6677')}`);
        console.log(`rgx.test('11-800-555-6677') is ${rgx.test('11-800-555-6677')}`);
        console.log(`rgx.test('1(800)555 6677') is ${rgx.test('1(800)555 6677')}`);
    }

    
})