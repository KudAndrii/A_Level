import ProductModel from "../Models/ProductModel";
import GetProductList from "../Requests/GetProductList";
import iPhone from "../Images/iPhone.jpg";
import oppo from "../Images/oppo.webp";
import samsung from "../Images/samsung.webp";
import xiaomi from "../Images/xiaomi.jpg";

const productList: ProductModel[] = GetProductList();

productList.forEach((element) => {
    switch (element.name) {
        case "iPhone":
            element.src = iPhone;
            break;
        case "Samsung Galaxy S22":
            element.src = samsung;
            break;
        case "Xiaomi 12":
            element.src = xiaomi;
            break;
        case "Oppo Reno 7":
            element.src = oppo;
            break;
        default:
            element.src = samsung;
            break;
    }
});

export default productList;
