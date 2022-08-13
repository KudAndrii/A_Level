import ProductCardComponent from "./ProductCardComponent";
import ProductModel from "../Models/ProductModel";

const CatalogComponent = (): JSX.Element => {
    const emptyMessage = "It is empty now :(";
    const sessionString = sessionStorage.getItem("ShoppingCart");
    let sessionList: ProductModel[] | null = null;
    if (sessionString) {
        sessionList = JSON.parse(sessionString);
    }

    if (!sessionList) {
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
                        {sessionList.map((x, index) => (
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
