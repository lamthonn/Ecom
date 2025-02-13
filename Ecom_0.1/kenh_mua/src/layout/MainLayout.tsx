import {  RouterProvider, useLocation, useNavigate } from "react-router-dom";
import { router } from "../routes/router";
import "../global.scss";
import React from "react";
import { Breadcrumb, Flex, Layout, Menu, MenuProps } from "antd";
import HeaderLayout from "./Header";
import "./HeaderLayout.scss"

const { Content, Footer, Sider } = Layout;

const MainLayout: React.FC<{children?: React.ReactNode }> = ({
  children
}) => {
  const location = useLocation(); // Lấy thông tin route hiện tại
  
  
  // Kiểm tra nếu route là "/login"
  if (location.pathname === "/login") {
    return <RouterProvider router={router} />;
  }

  return (
    <Layout className="header-component">
      <HeaderLayout />
      <Content style={{ padding: '0 48px', }}>
        <Breadcrumb style={{ margin: '16px 0' }}>
          <Breadcrumb.Item>Home</Breadcrumb.Item>
          <Breadcrumb.Item>List</Breadcrumb.Item>
          <Breadcrumb.Item>App</Breadcrumb.Item>
        </Breadcrumb>
        <div
          style={{
            backgroundColor: "#FFFFFF",
            minHeight: 280,
            padding: 24,
            borderRadius: 5,
          }}
        >
          {children}
        </div>
      </Content>
      <Footer style={{ textAlign: 'center' }}>
        Ant Design ©{new Date().getFullYear()} Created by Ant UED
      </Footer>
    </Layout>
  );
};

export default MainLayout;
