import ProductCardComponent from "./ProductCardComponent";
import ProductModel from "../Models/ProductModel";
import GetProductList from "../Requests/GetProductList";

const CatalogComponent = (): JSX.Element => {
    const productList: ProductModel[] = GetProductList();

    return (
        <>
            <div className="container my-5">
                <div className="row mx-auto row-cols-1 row-cols-md-2 row-cols-lg-3 g-5">
                    {productList &&
                        productList.map((x, index) => (
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
