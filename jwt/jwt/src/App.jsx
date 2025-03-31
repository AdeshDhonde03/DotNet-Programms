import { useState } from 'react';
import { BrowserRouter, Routes, Route } from 'react-router-dom'; // Import BrowserRouter, Routes, and Route
import './App.css';
import AuthForm from './Component/AuthForm';
import Dashboard from './Component/Dashboard';
import ProtectedRoute from './Component/ProtectedRoute';
import { AuthProvider } from './Component/AuthContext';

function App() {
  const [count, setCount] = useState(0);

  return (
    <>
      <AuthProvider>
        <BrowserRouter> {/* Use BrowserRouter instead of Router */}
          <Routes> {/* Wrap Route components with Routes */}
            <Route path="/" element={<AuthForm />} />
            <Route path="/dashboard" element={<ProtectedRoute><Dashboard /></ProtectedRoute>} />
          </Routes>
        </BrowserRouter>
      </AuthProvider>
    </>
  );
}

export default App;