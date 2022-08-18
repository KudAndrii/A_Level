import headerLogo from "../Images/headerLogo.png";
import { Link, Outlet, Route, Routes, useParams } from "react-router-dom";

const HeaderComponent = (): JSX.Element => {
    return (
        <>
            <nav className="navbar navbar-expand navbar-dark bg-dark">
                <div className="container">
                    <Link className="navbar-brand p-0" to="/">
                        <img src={headerLogo} alt="A.I." width="80em" />
                    </Link>
                    <div className="collapse navbar-collapse" id="">
                        <ul className="navbar-nav">
                            <li className="nav-item">
                                <Link className="nav-link" to="/">
                                    Home
                                </Link>
                            </li>
                            <li className="nav-item">
                                <Link className="nav-link" to="/catalog">
                                    Catalog
                                </Link>
                            </li>
                            <li className="nav-item">
                                <Link className="nav-link" to="/cart">
                                    Shopping Cart
                                </Link>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>
            <Outlet />
        </>
    );
};

export default HeaderComponent;
