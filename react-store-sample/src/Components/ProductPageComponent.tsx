import { FC } from "react";
import ProductType from "../Types/ProductType";
import iPhone from "../Images/iPhone.jpg";
import oppo from "../Images/oppo.webp";
import samsung from "../Images/samsung.webp";
import xiaomi from "../Images/xiaomi.jpg";
import "./ComponentsStyles.css";

type childType = {
    productType: ProductType;
};

const ProductCardComponent: FC<childType> = (props: childType): JSX.Element => {
    switch (props.productType.name) {
        case "iPhone":
            props.productType.src = iPhone;
            break;
        case "Samsung Galaxy S22":
            props.productType.src = samsung;
            break;
        case "Xiaomi 12":
            props.productType.src = xiaomi;
            break;
        case "Oppo Reno 7":
            props.productType.src = oppo;
            break;
        default:
            props.productType.src = samsung;
            break;
    }

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
                            <a
                                href="https://en.wikipedia.org/wiki/New_Zealand"
                                className="btn btn-primary descriptionButton"
                                target="_blank"
                            >
                                Details
                            </a>
                            <a
                                href="https://en.wikipedia.org/wiki/New_Zealand"
                                className="btn btn-primary"
                                target="_blank"
                            >
                                Add to cart
                            </a>
                        </div>
                    </div>
                </div>
            </div>
        </>
    );
};

export default ProductCardComponent;
