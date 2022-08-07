import { FC, useEffect, useState } from "react";
import GetResource from "../Http/GetResourceRequest";
import ResourseModel from "../Models/ResourceModel";
import DataResourse from "../Models/DataResourceModel";
import Support from "../Models/SupportModel";

type TypeForChild = {
  data: DataResourse;
  support: Support;
};

const ChildResponseComponent: FC<TypeForChild> = (
  props: TypeForChild
): JSX.Element => {
  return (
    <>
      <div>{props?.data.name}</div>
      <div>{props?.data.year}</div>
    </>
  );
};

export default ChildResponseComponent;
