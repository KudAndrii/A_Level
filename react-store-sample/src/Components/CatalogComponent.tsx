import ProductCardComponent from "./ProductCardComponent";
import { ProductListContext } from "../index";
import { useContext } from "react";

const CatalogComponent = (): JSX.Element => {
    const ProductListContextValue = useContext(ProductListContext);

    return (
        <>
            <div className="container my-5">
                <div className="row mx-auto row-cols-1 row-cols-md-2 row-cols-lg-3 g-5">
                    {ProductListContextValue &&
                        ProductListContextValue.map((x, index) => (
                            <div key={index}>
                                <ProductCardComponent
                                    productType={x}
                                ></ProductCardComponent>
                            </div>
                        ))}
                </div>
            </div>
        </>
    );
};

export default CatalogComponent;
