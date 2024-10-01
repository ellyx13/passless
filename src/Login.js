import React, { useState } from 'react';

// Dữ liệu mẫu người dùng (có thể thay bằng API gọi tới backend)
const mockUserData = {
  username: 'user123',
  email: 'user123@example.com',
  password: 'Password!1'
};

function Login({ toggle }) {
  const [input, setInput] = useState('');
  const [password, setPassword] = useState('');
  const [message, setMessage] = useState('');

  const handleLogin = (e) => {
    e.preventDefault();
    // Kiểm tra xem người dùng nhập Email hoặc Username
    const isEmail = input.includes('@');
    // So sánh thông tin đăng nhập với dữ liệu mẫu
    if (
      (isEmail && input === mockUserData.email && password === mockUserData.password) ||
      (!isEmail && input === mockUserData.username && password === mockUserData.password)
    ) {
      setMessage('Login successful!');
    } else {
      setMessage('Invalid username/email or password.');
    }
  };

  return (
    <div className="login-container">
      <h2>Login</h2>
      <form onSubmit={handleLogin}>
        <div className="form-group">
          <label>Username or Email</label>
          <input 
            type="text" 
            value={input}
            onChange={(e) => setInput(e.target.value)}
            placeholder="Enter your username or email"
            required
          />
        </div>
        <div className="form-group">
          <label>Password</label>
          <input 
            type="password" 
            value={password}
            onChange={(e) => setPassword(e.target.value)}
            placeholder="Enter your password"
            required
          />
        </div>
        <button type="submit">Login</button>
        {message && <p className="message">{message}</p>} {/* Hiển thị thông báo */}
      </form>
      <p>Don't have an account? <span onClick={toggle} className="link">Register here</span></p>
    </div>
  );
}

export default Login;
