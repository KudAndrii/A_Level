import { FC, useContext, useEffect, useState } from "react";
import { Button } from "react-bootstrap";
import { Link, Outlet } from "react-router-dom";
import ProductType from "../Types/ProductType";
import "./ComponentsStyles.css";
import { ShoppingCartContext } from "../index";

type childType = {
    productType: ProductType;
    inCart: boolean;
};

const ProductCardComponent: FC<childType> = (props: childType): JSX.Element => {
    const ShoppingCartContextValue = useContext(ShoppingCartContext);
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
                                className="btn btn-primary descriptionButton"
                            >
                                Details
                            </Link>
                            {props.inCart || (
                                <Button
                                    className="btn"
                                    onClick={() => {
                                        ShoppingCartContextValue.push(
                                            props.productType
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
