import { FC, useEffect, useState } from "react";
import GetResource from "../Http/GetResourceRequest";
import ResourseModel from "../Models/ResourceModel";

type ChildResponseProps = {
  resourseId: string;
};

const ChildResponseComponent: FC<ChildResponseProps> = (
  props: ChildResponseProps
): JSX.Element => {
  const [newRespourse, setResourse] = useState<ResourseModel>();

  useEffect(() => {
    async function init() {
      let id: number = Number(props.resourseId) || 23;

      const result = await GetResource(id);
      setResourse(result);
    }

    init();
  });

  return (
    <>
      <div>{newRespourse?.data.name}</div>
      <div>{newRespourse?.data.year}</div>
    </>
  );
};

export default ChildResponseComponent;
