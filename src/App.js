import React, { useState } from 'react';
import './App.css';
import Login from './Login';
import Register from './Register';

function App() {
  const [isLogin, setIsLogin] = useState(true);

  const toggleForm = () => {
    setIsLogin(!isLogin);
  };

  return (
    <div className="app-container">
      {isLogin ? <Login toggle={toggleForm} /> : <Register toggle={toggleForm} />}
    </div>
  );
}

export default App;
