import { FC } from "react";
import { Link, Outlet } from "react-router-dom";
import ProductType from "../Types/ProductType";
import "./ComponentsStyles.css";

type childType = {
    productType: ProductType;
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
                                className="btn btn-primary descriptionButton"
                            >
                                Details
                            </Link>
                            <a
                                href="https://en.wikipedia.org/wiki/New_Zealand"
                                className="btn btn-primary"
                            >
                                Add to cart
                            </a>
                        </div>
                    </div>
                </div>
            </div>
            <Outlet />
        </>
    );
};

export default ProductCardComponent;
