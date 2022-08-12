import ProductCardComponent from "./ProductCardComponent";
import { ShoppingCartContext } from "../index";
import { useContext } from "react";

const CatalogComponent = (): JSX.Element => {
    const ShoppingCartContextValue = useContext(ShoppingCartContext);
    const emptyMessage = "It is empty now :(";

    if (ShoppingCartContextValue.length == 0) {
        return (
            <>
                <h1 className="emptyMessage">{emptyMessage}</h1>
            </>
        );
    } else {
        return (
            <>
                <div className="container my-5">
                    <div className="row mx-auto row-cols-1 row-cols-md-2 row-cols-lg-3 g-5">
                        {ShoppingCartContextValue &&
                            ShoppingCartContextValue.map((x, index) => (
                                <div key={index}>
                                    <ProductCardComponent
                                        productType={x}
                                        inCart={true}
                                    ></ProductCardComponent>
                                </div>
                            ))}
                    </div>
                </div>
            </>
        );
    }
};

export default CatalogComponent;
