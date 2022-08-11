import ProductModel from "../Models/ProductModel";
import { config } from "../shopConfig";

const GetProductList = (): ProductModel[] => {
    const result: ProductModel[] = config.productList;

    return result;
};

export default GetProductList;
