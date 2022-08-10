import { config } from "../apiConfig";
import Resource from "../Models/ResourceModel";

let statusCode: number;

const GetResource = async (id: number): Promise<Resource> => {
  const result: Response = await fetch(`${config.reqresUrl}/api/unknown/${id}`);
  const body = await result.json();
  statusCode = result.status;
  return body as Resource;
};

export { GetResource, statusCode };
