function createCookie(token) {
    let name = "bearerJwt";
    document.cookie = name + "=" + token + "; path=/";
};

function getJwtToken() {
    var name = "bearerJwt=";
    var decodedCookie = decodeURIComponent(document.cookie);
    var ca = decodedCookie.split(';');
    for (var i = 0; i < ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0) == ' ') {
            c = c.substring(1);
        }
        if (c.indexOf(name) == 0) {
            return c.substring(name.length, c.length);
        }
    }
    return "";
};

function deleteJwtToken() {
    document.cookie = "bearerJwt=; expires=Thu, 01 Jan 1970 00:00:00 UTC; path=/;";
}

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