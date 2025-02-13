import { createBrowserRouter, Navigate } from "react-router-dom";
import React from 'react';
import Dashboard from "../pages/admin-page/Dashboard/index";
import LoginPage from "../pages/login";
import RegisterPage from "../pages/register";
import AdminLogin from "../pages/admin-page/Authen/AdminLogin";
import NotFoundPage from "../notFoundPage";
import TestComponent from "../pages/admin-page/TestComponent";
import { routesConfig } from "./routes";
import MainLayout from "../layout/MainLayout";

export const router = createBrowserRouter([
  //người mua
  {
    path: "login",
    element: <LoginPage />
  },
  {
    path: "register",
    element: <RegisterPage />
  },
  {
    path: "trang-chu",
    element: (
      <MainLayout>
        <>trang chủ</>
      </MainLayout>
    )
  },

  //các trường hợp khác
  //path mặc định
  {
    path: "",
    element: <Navigate to="/trang-chu" replace />
  },
  //404 not found
  {
    path: "not-found",
    element: <NotFoundPage /> // Hiển thị trang 404
  },
  {
    path: "*",
    element: <Navigate to="/not-found" replace /> // Chuyển hướng đến /not-found nếu đường dẫn không hợp lệ
  }
]);
