import ProductModel from "../Models/ProductModel";
import GetProductList from "../Requests/GetProductList";
import iPhone from "../Images/iPhone.jpg";
import oppo from "../Images/oppo.webp";
import samsung from "../Images/samsung.webp";
import xiaomi from "../Images/xiaomi.jpg";
import { makeAutoObservable } from "mobx";

export class ProductRangeService {
    productList: ProductModel[] = [];

    constructor() {
        makeAutoObservable(this);

        this.setProductList();
    }

    private setProductList() {
        this.productList = GetProductList();
        this.productList.forEach((element) => {
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
    }

    deleteProduct(id: number) {
        const objForDelete = this.productList.find((obj) => {
            return obj.id === id;
        });
        let index: number = -1;
        if (objForDelete) {
            index = this.productList.indexOf(objForDelete);
        }
        if (index !== -1) {
            this.productList.splice(index, 1);
        }
    }
}
