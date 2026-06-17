# Device Monitor Platform

IP-GUARD 二次开发的设备状态监测平台项目骨架。

## 项目背景

面向已采购 IP-GUARD 的客户，构建一个可快速交付、可二次开发的设备监控平台，用于设备状态监测、日志管理、待处理事件跟踪、用户权限管理与审计。

## 技术栈

- 后端：ASP.NET 8 Web API
- 前端：HTML5 + Bootstrap 5 + JavaScript
- 数据库：SQL Server 2016
- 部署：Windows Server 2022 + IIS

## 目录结构

- `Backend/DeviceMonitorAPI/`：后端 API 项目
- `Frontend/`：前端静态页面与资源
- `Database/`：数据库初始化脚本
- `Docs/`：项目文档

## 快速开始

1. 初始化数据库：执行 `Database/init-schema.sql` 与 `Database/init-data.sql`
2. 配置后端连接字符串：编辑 `Backend/DeviceMonitorAPI/appsettings.json`
3. 启动后端：
   - `cd Backend/DeviceMonitorAPI`
   - `dotnet restore`
   - `dotnet run`
4. 使用静态文件服务器或 IIS 打开 `Frontend/` 页面

## 核心模块

- 用户认证与角色权限管理
- 设备信息管理
- 监控日志管理
- 待处理事件管理
- 仪表板统计
- 操作日志审计

## 后续开发建议

- 对接真实 IP-GUARD 数据源或中间库
- 完善 JWT 认证与授权策略
- 增加 Excel 导出能力
- 增加日志抓取服务（Windows Service / C/S 程序）
- 增加部门树、设备分组与轮巡显示能力
