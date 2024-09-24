function togglePassword() {
    const passwordField = document.getElementById('password');
    const confirmPasswordField = document.getElementById('confirm-password');
    const passwordToggle = document.getElementById('password-toggle');
    
    if (passwordField.type === 'password') {
        passwordField.type = 'text';
        confirmPasswordField.type = 'text';
        passwordToggle.textContent = 'Hide Password';
    } else {
        passwordField.type = 'password';
        confirmPasswordField.type = 'password';
        passwordToggle.textContent = 'Show Password';
    }
}

// Xác thực form
document.getElementById('signup-form').addEventListener('submit', function(event) {
    const username = document.getElementById('username').value;
    const email = document.getElementById('email').value;
    const password = document.getElementById('password').value;
    const confirmPassword = document.getElementById('confirm-password').value;

    // Kiểm tra tên người dùng
    if (username.length < 3) {
        alert('Username must be at least 3 characters long.');
        event.preventDefault();
        return;
    }

    // Kiểm tra email
    const emailPattern = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    if (!emailPattern.test(email)) {
        alert('Invalid email address.');
        event.preventDefault();
        return;
    }

    // Kiểm tra mật khẩu và mật khẩu xác nhận
    if (password !== confirmPassword) {
        alert('Passwords do not match.');
        event.preventDefault();
    }
});
