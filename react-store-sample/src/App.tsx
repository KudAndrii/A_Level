import "./App.css";
import HeaderComponent from "./Components/HeaderComponent";
import CatalogComponent from "./Components/CatalogComponent";
import { Link, Outlet, Route, Routes, useParams } from "react-router-dom";
import ProductPageComponent from "./Components/ProductPageComponent";

function App() {
    return (
        <>
            <HeaderComponent></HeaderComponent>
            <Routes>
                <Route path="catalog" element={<CatalogComponent />} />
                <Route path="phone/:id" element={<ProductPageComponent />} />
            </Routes>
        </>
    );
}

export default App;
