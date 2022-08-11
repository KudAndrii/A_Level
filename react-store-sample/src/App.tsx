import React from "react";
import logo from "./logo.svg";
import "./App.css";
import HeaderComponent from "./Components/HeaderComponent";
import CatalogComponent from "./Components/CatalogComponent";

function App() {
    return (
        <>
            <HeaderComponent></HeaderComponent>
            <CatalogComponent></CatalogComponent>
        </>
    );
}

export default App;
