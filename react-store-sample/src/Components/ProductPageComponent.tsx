import { FC, useContext } from "react";
import ProductType from "../Types/ProductType";
import "./ComponentsStyles.css";
import { ProductListContext } from "../index";
import { useParams } from "react-router";

type childType = {
    productType: ProductType;
};

const ProductPageComponent: FC = (): JSX.Element => {
    const ProductListContextValue = useContext(ProductListContext);
    const { id } = useParams();
    const product = ProductListContextValue.find((prod) => {
        return prod.id === Number(id);
    });

    return (
        <>
            <div className="col">
                <div className="card">
                    <img
                        src={product?.src}
                        className="card-img-top"
                        alt="phone image"
                    />
                    <div className="card-body">
                        <h5 className="card-title">{product?.name}</h5>
                        <p className="card-text">{product?.shortDescription}</p>
                        <p className="card-text">{product?.price}</p>
                        <p className="card-text">{product?.description}</p>
                    </div>
                </div>
            </div>
        </>
    );
};

export default ProductPageComponent;
