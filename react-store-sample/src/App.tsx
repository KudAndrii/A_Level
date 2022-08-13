import "./App.css";
import HeaderComponent from "./Components/HeaderComponent";
import CatalogComponent from "./Components/CatalogComponent";
import { Route, Routes } from "react-router-dom";
import ProductPageComponent from "./Components/ProductPageComponent";
import ShoppingCartComponent from "./Components/ShoppingCartComponent";
import HomePageComponent from "./Components/HomePageComponent";
import { ProductRangeService } from "./Services/ProductRangeService";
import { SessionStorageService } from "./Services/SessionStorageService";

export const productRangeService = new ProductRangeService();
export const sessionStorageService = new SessionStorageService();

function App() {
    return (
        <>
            <HeaderComponent></HeaderComponent>
            <Routes>
                <Route path="/" element={<HomePageComponent />} />
                <Route path="catalog" element={<CatalogComponent />} />
                <Route path="phone/:id" element={<ProductPageComponent />} />
                <Route path="cart" element={<ShoppingCartComponent />} />
            </Routes>
        </>
    );
}

export default App;
