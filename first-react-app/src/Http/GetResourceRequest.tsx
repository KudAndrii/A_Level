import { config } from "../apiConfig";
import Resource from "../Models/ResourceModel";

const GetResource = async (id: number): Promise<Resource> => {
  const result: Response = await fetch(`${config.reqresUrl}/api/unknown/${id}`);
  const body = await result.json();

  return body as Resource;
};

export default GetResource;
