import { useAuth } from "./AuthContext";
import { Link } from "react-router-dom";
import "./dashboard.css"; // Import CSS file

const Dashboard = () => {
    const { logout } = useAuth();

    return (
        <div className="dashboard">
            {/* Navbar */}
            <nav className="navbar">
                <h1>My Dashboard</h1>
                <ul className="nav-links">
                    <li><Link to="/dashboard">Home</Link></li>
                    <li><Link to="/aboutus">About Us</Link></li>
                    <li><Link to="/contactus">Contact Us</Link></li>
                    <li><button className="logout-btn" onClick={logout}>Log Out</button></li>
                </ul>
            </nav>

            {/* Main Content */}
            <main className="main-content">
                <h2>Welcome to Your Dashboard</h2>
                <p>This is your dashboard where you can manage everything.</p>
            </main>

            {/* Footer */}
            <footer className="footer">
                &copy; {new Date().getFullYear()} MyApp. All rights reserved.
            </footer>
        </div>
    );
};

export default Dashboard;
