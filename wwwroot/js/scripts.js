//CreateCookie: function (name, value, days) {
//    var expires;
//    if (days) {
//        var date = new Date();
//        date.setTime(date.getTime() + (days * 24 * 60 * 60 * 1000));
//        expires = "; expires=" + date.toGMTString();
//    }
//    else {
//        expires = "";
//    }
//    document.cookie = name + "=" + value + expires + "; path=/";
//},

function enableLoginNavMenu() {
    document.getElementById('navMenuLogin').style.display = 'flex';
    document.getElementById('navMenuAdmin').style.display = 'none';
    document.getElementById('navMenuStudent').style.display = 'none';
};

function enableNavStudentLogged() {
    document.getElementById('navMenuStudent').style.display = 'flex';
    document.getElementById('navMenuLogin').style.display = 'none';
};

function enableNavAdminLogged() {
    document.getElementById('navMenuAdmin').style.display = 'flex';
    document.getElementById('navMenuLogin').style.display = 'none';
};