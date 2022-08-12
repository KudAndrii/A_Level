import { FC, useContext } from "react";
import ProductType from "../Types/ProductType";
import "./ComponentsStyles.css";
import { ProductListContext, ShoppingCartContext } from "../index";
import { useParams } from "react-router";
import "./ComponentsStyles.css";
import { Button } from "react-bootstrap";

type childType = {
    inCart: boolean;
};

const ProductPageComponent: FC = (): JSX.Element => {
    const ProductListContextValue = useContext(ProductListContext);
    const { id } = useParams();
    const product = ProductListContextValue.find((prod) => {
        return prod.id === Number(id);
    });
    const ShoppingCartContextValue = useContext(ShoppingCartContext);

    return (
        <>
            <div className="productPage">
                <div className="productDescription">
                    <img
                        src={product?.src}
                        className="pageImage"
                        alt="phone image"
                    />
                    <h3 className="productName">{product?.name}</h3>
                </div>
                <div className="productDescription">
                    <h5 className="card-text">{product?.shortDescription}</h5>
                    <h2 className="card-text">{product?.price} ₴</h2>
                    <p className="card-text">{product?.description}</p>
                    <Button
                        className="btn"
                        onClick={() => {
                            if (product) {
                                ShoppingCartContextValue.push(product);
                            }
                        }}
                    >
                        Add to cart
                    </Button>
                </div>
            </div>
        </>
    );
};

export default ProductPageComponent;
