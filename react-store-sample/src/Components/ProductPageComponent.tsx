import { FC } from "react";
import "./ComponentsStyles.css";
import { productRangeService } from "../App";
import { useParams } from "react-router";
import "./ComponentsStyles.css";
import { Button } from "react-bootstrap";
import { sessionStorageService } from "../App";
import { SessionStorageService } from "../Services/SessionStorageService";

const ProductPageComponent: FC = (): JSX.Element => {
    const { id } = useParams();
    const product = productRangeService.productList.find((prod) => {
        return prod.id === Number(id);
    });

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
                        className="btn marginRightButton"
                        onClick={() => {
                            const sessionList =
                                sessionStorageService.GetShoppingCart();
                            if (product) {
                                sessionList.push(product);
                                sessionStorageService.SetShoppingCart(
                                    sessionList
                                );
                            }
                        }}
                    >
                        Add to cart
                    </Button>
                    <Button
                        className="btn"
                        onClick={() => {
                            const sessionList =
                                sessionStorageService.GetShoppingCart();
                            for (
                                let index = 0;
                                index < sessionList.length;
                                index++
                            ) {
                                if (sessionList[index].id === product?.id) {
                                    sessionList.splice(index, 1);
                                }
                            }
                            sessionStorageService.SetShoppingCart(sessionList);

                            for (
                                let index = 0;
                                index < productRangeService.productList.length;
                                index++
                            ) {
                                if (
                                    productRangeService.productList[index]
                                        .id === product?.id
                                ) {
                                    productRangeService.productList.splice(
                                        index,
                                        1
                                    );
                                }
                            }
                            // const sessionList =
                            //     sessionStorageService.GetShoppingCart();
                            // if (product) {
                            //     sessionList.push(product);
                            //     sessionStorageService.SetShoppingCart(
                            //         sessionList
                            //     );
                            // }
                        }}
                    >
                        Delete
                    </Button>
                </div>
            </div>
        </>
    );
};

export default ProductPageComponent;
