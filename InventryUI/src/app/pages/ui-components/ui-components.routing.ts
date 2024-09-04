import { Routes } from '@angular/router';
import { UsersComponent } from './users/users.component';
import { RolesComponent } from './roles/roles.component';
import { AddRoleComponent } from './roles/add-role/add-role.component';
import { BrandComponent } from './brand/brand.component';
import { AddBrandComponent } from './brand/add-brand/add-brand.component';
import { UpdateBrandComponent } from './brand/update-brand/update-brand.component';
import { SupplierComponent } from './supplier/supplier.component';
import { AddSupplierComponent } from './supplier/add-supplier/add-supplier.component';
import { UpdateSupplierComponent } from './supplier/update-supplier/update-supplier.component';
import { CategoryComponent } from './category/category.component';
import { AddCategoryComponent } from './category/add-category/add-category.component';
import { UpdateCategoryComponent } from './category/update-category/update-category.component';
import { DeviceComponent } from './device/device.component';
import { AddDeviceComponent } from './device/add-device/add-device.component';
import { UpdateDeviceComponent } from './device/update-device/update-device.component';
import { UpdateRoleComponent } from './roles/update-role/update-role.component';
import { UpdateUserRoleComponent } from './users/update-user-role/update-user-role.component';
import { UpdateUserComponent } from './users/update-user/update-user.component';
import { EmployeeComponent } from './employee/employee.component';
import { AddEmployeeComponent } from './employee/add-employee/add-employee.component';
import { UpdateEmployeeComponent } from './employee/update-employee/update-employee.component';
import { OfficeComponent } from './office/office.component';
import { AddOfficeComponent } from './office/add-office/add-office.component';
import { UpdateOfficeComponent } from './office/update-office/update-office.component';
import { AssignDeviceComponent } from './assign/assign-device/assign-device.component';
import { AssignOfficeComponent } from './assign/assign-office/assign-office.component';
import { EmployeeDetailsComponent } from './employee/employee-details/employee-details.component';
import { OfficeDetailsComponent } from './office/office-details/office-details.component';
import { FaultyDeviceComponent } from './faulty-device/faulty-device.component';
import { UpdateFaultyComponent } from './faulty-device/update-faulty/update-faulty.component';
import { AddUserComponent } from './users/add-user/add-user.component';

export const UiComponentsRoutes: Routes = [
  {
    path: '',
    children: [
      {path: 'user', component: UsersComponent,},
      {path: 'add-user', component: AddUserComponent,},
      { path: 'update-user/:id', component: UpdateUserComponent },
      {path: 'roles',component: RolesComponent, },
      { path: 'add-role', component: AddRoleComponent },
      { path: 'update-role/:id', component: UpdateRoleComponent },
      {path: 'brand',component: BrandComponent, },
      { path: 'add-brand', component: AddBrandComponent },
      { path: 'update-brand/:id', component: UpdateBrandComponent },
      {path: 'supplier',component: SupplierComponent, },
      { path: 'add-supplier', component: AddSupplierComponent },
      { path: 'update-supplier/:id', component: UpdateSupplierComponent },
      {path: 'category',component: CategoryComponent, },
      { path: 'add-category', component: AddCategoryComponent },
      { path: 'update-category/:id', component: UpdateCategoryComponent },
      {path: 'device',component: DeviceComponent, },
      { path: 'add-device', component: AddDeviceComponent },
      { path: 'update-device/:id', component: UpdateDeviceComponent },
      {path: 'employee',component: EmployeeComponent, },
      { path: 'add-employee', component: AddEmployeeComponent },
      { path: 'update-employee/:id', component: UpdateEmployeeComponent },
      {path: 'office',component: OfficeComponent, },
      { path: 'add-office', component:AddOfficeComponent },
      { path: 'update-office/:id', component: UpdateOfficeComponent },
      {path: 'assign-employee',component: AssignDeviceComponent },
      {path: 'assign-office',component: AssignOfficeComponent },
      {path: 'employee-device/:id',component: EmployeeDetailsComponent },
      {path: 'office-device/:id',component: OfficeDetailsComponent },
      {path: 'faulty-device',component: FaultyDeviceComponent },
      { path: 'update-fault/:id', component: UpdateFaultyComponent },
    ],
  },
];
