import { config } from "../apiConfig";
import Resource from "../Models/ResourceModel";

const GetResource = async (): Promise<Resource> => {
  const result: Response = await fetch(`${config.reqresUrl}/api/unknown/2`);
  const body = await result.json();

  return body as Resource;
};

export default GetResource;
