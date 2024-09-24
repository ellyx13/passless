// Chức năng chuyển đổi hiển thị mật khẩu
function togglePassword() {
    var passwordInput = document.getElementById("password");
    if (passwordInput.type === "password") {
      passwordInput.type = "text";
    } else {
      passwordInput.type = "password";
    }
  }
  
  // Chặn submit form mặc định và kiểm tra dữ liệu
  document.getElementById("loginForm").addEventListener("submit", function(event) {
    event.preventDefault(); // Chặn reload trang
  
    // Lấy giá trị từ form
    var username = document.getElementById("username").value;
    var password = document.getElementById("password").value;
  
    // Thực hiện kiểm tra đăng nhập
    alert("Username: " + username + "\nPassword: " + password);
  });
  