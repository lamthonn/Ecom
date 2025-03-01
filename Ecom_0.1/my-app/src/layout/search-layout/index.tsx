import { Collapse, CollapseProps } from 'antd';
import "./index.scss"
import React from 'react';
import {
  CaretRightOutlined
} from "@ant-design/icons"
import ButtonCustom from '../../components/button/button';

const SearchLayout:React.FC<{children: React.ReactNode, style?: React.CSSProperties}> = ({
    children,
    style
}) => {
    const itemsCollapse: CollapseProps["items"] = [
        {
          key: "1",
          label: "Tìm kiếm thông tin",
          children: (
              <div>
                <div>{children}</div>
                <div style={{display:"flex", justifyContent:"center"}}>
                  <ButtonCustom text='Tìm kiếm' variant='solid'/>
                </div>
              </div>
          ),
        },
      ];
    return(
        <Collapse 
            className='search-layout'
            items={itemsCollapse}
            style={style}
            expandIcon={({ isActive }) => <CaretRightOutlined rotate={isActive ? 90 : 0} />}
        />
    )
}
export default SearchLayout;
