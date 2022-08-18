import { FC, useContext } from "react";
import { Button } from "react-bootstrap";
import { Link, Outlet } from "react-router-dom";
import ProductType from "../Types/ProductType";
import "./ComponentsStyles.css";
import ProductModel from "../Models/ProductModel";
import { sessionStorageService } from "../App";

type childType = {
    productType: ProductType;
    inCart: boolean;
};

const ProductCardComponent: FC<childType> = (props: childType): JSX.Element => {
    return (
        <>
            <div className="col">
                <div className="card">
                    <img
                        src={props.productType.src}
                        className="card-img-top"
                        alt="phone image"
                    />
                    <div className="card-body">
                        <h5 className="card-title">{props.productType.name}</h5>
                        <p className="card-text">
                            {props.productType.shortDescription}
                        </p>
                        <div>
                            <Link
                                to={"/phone/" + props.productType.id}
                                className="btn btn-primary marginRightButton"
                            >
                                Details
                            </Link>
                            {props.inCart || (
                                <Button
                                    className="btn"
                                    onClick={() => {
                                        const sessionList =
                                            sessionStorageService.GetShoppingCart();
                                        sessionList.push(props.productType);
                                        sessionStorageService.SetShoppingCart(
                                            sessionList
                                        );
                                    }}
                                >
                                    Add to cart
                                </Button>
                            )}
                        </div>
                    </div>
                </div>
            </div>
            <Outlet />
        </>
    );
};

export default ProductCardComponent;
