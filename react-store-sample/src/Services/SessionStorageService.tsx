import ProductModel from "../Models/ProductModel";

export class SessionStorageService {
    private key: string = "ShoppingCart";

    GetShoppingCart(): ProductModel[] {
        const sessionString = sessionStorage.getItem(this.key);
        if (!sessionString) {
            return [];
        } else {
            return JSON.parse(sessionString) as ProductModel[];
        }
    }

    SetShoppingCart(productList: ProductModel[]) {
        sessionStorage.setItem(this.key, JSON.stringify(productList));
    }
}
