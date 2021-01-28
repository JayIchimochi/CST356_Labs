function validate() {
    
    document.getElementById('username-error').style.visibility = 'hidden';
    document.getElementById('password-error').style.visibility = 'hidden';

    let username = document.getElementById('username').value;
    let password = document.getElementById('last-name').value;

    console.debug('username: ' + username);

    console.debug('password: ' + password);

    if (username == '') {
        document.getElementById('username-error').style.visibility = 'visible';
    }

    if (password == '') {
        document.getElementById('password-error').style.visibility = 'visible';
    }

    document.cookie = `username=${username}; expires=31 Dec 2024 12:00:00 UTC; path=/`;
}