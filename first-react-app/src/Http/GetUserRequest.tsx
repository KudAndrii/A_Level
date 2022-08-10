import { config } from "../apiConfig";
import User from "../Models/UserModel";

const GetUser = async (): Promise<User> => {
  const result: Response = await fetch(`${config.reqresUrl}/api/users/2`);
  const body = await result.json();

  const castedBody = body as User;

  return castedBody;
};

export default GetUser;
