import { TeamOutlined, UserOutlined } from "@ant-design/icons";
import { MenuProps } from "antd";
import React from 'react';


export const config = {
    
}

export const menuItem :MenuProps["items"] = [
    {
      key: "thong-ke",
      icon: React.createElement(UserOutlined), 
      label: "Thống kê",
      children: [
        {
          key: "dashboard",
          label: "Dashboard",
        },
      ],
    },
    {
      key: "test-component",
      icon: React.createElement(TeamOutlined), 
      label: "Common Component",
    },
  ];