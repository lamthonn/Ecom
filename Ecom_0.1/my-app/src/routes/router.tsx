import { createBrowserRouter, Navigate } from "react-router-dom";
import React from 'react';
import Dashboard from "../pages/admin-page/Dashboard/index";
import LoginPage from "../pages/login";
import RegisterPage from "../pages/register";
import AdminLogin from "../pages/admin-page/Authen/AdminLogin";
import NotFoundPage from "../notFoundPage";
import ProtectedRoute from "./PrivateRoute";
import TestComponent from "../pages/admin-page/TestComponent";
import { routesConfig } from "./routes";

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
    element: <>trang chủ</>
  },
  //người bán
  {
    path: "seller-center",
    children:[
      {
        path: "login",
        element: <AdminLogin />
      },
      {
        path: routesConfig.dashboard,
        element:(
          <ProtectedRoute>
            <Dashboard />
          </ProtectedRoute>
        )
      },
      {
        path: routesConfig.testComponent,
        element:(
          <ProtectedRoute>
            <TestComponent />
          </ProtectedRoute>
        )
      },
    ]
  },

  //các trường hợp khác
  //path mặc định
  {
    path: "",
    element: <Navigate to="/seller-center/dashboard" replace />
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
