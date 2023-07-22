
import { AuthService } from 'src/app/components/auth.service';
import {  Router } from '@angular/router';
import { UserService } from 'src/app/components/user.service';
import { Component } from '@angular/core';
@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  title = 'materialProject';
  username: string = ''; // Initialize the username variable

  constructor(private authService: AuthService,private router:Router,private userService: UserService) {}

  ngOnInit(): void {
    // Fetch the username from the service or API call
    this.userService.getUsername().subscribe((username: string) => {
      this.username = username;
    });
  }
  menuItemsByUsername: { [key: string]: any[] } = {
    'vignesh': [
  
     
   
        {
          title: 'Dispensing',
          icon: 'menu',
          preventNavigation: true,
          children: [
            {
              title: 'Material Picking',
              route: "/dispensing",
              icon: 'subtitles'
            },
            {
              title: 'Picked Material Label Printing',
              route: "/dispensing",
              icon: 'subtitles'
            },
            {
              title: 'Material Dispensing',
              route: "/dispensing",
              icon: 'subtitles'
            },
            {
              title: 'Palletisation',
              route: "/dispensing",
              icon: 'subtitles'
            },
            {
              title: 'Container Label Print',
              route: "/dispensing",
              icon: 'subtitles'
            },
            {
              title: 'Loose Container',
              route: "/dispensing",
              icon: 'subtitles'
            },
            {
              title: 'Post To Sap',
              route: "/dispensing",
              icon: 'subtitles'
            },
            {
              title: 'Picking Cancellation',
              route: "/dispensing",
              icon: 'subtitles'
            },
            {
              title: 'Miscellaneous Items',
              route: "/dispensing",
              icon: 'subtitles'
            },
            {
              title: 'Quantity Adjustment',
              route: "/dispensing",
              icon: 'subtitles'
            },
          ]
        },
  
  
        {
          title: 'Reprint',
          route: "/Reprint",
          icon: 'menu'
        },
        {
          title: 'HDPE',
          route: "/hdpe",
          icon: 'menu'
        },
        {
          title: 'Material Tracking',
          route: "/materialTracking",
          icon: 'menu'
        }
      ]
      
     , // Add other menu items specific to 'vignesh'
   
    'naveen': [
      {
        title: 'Inward Entry',
        route: '/InwardEntry',
        icon: 'menu',
      },
      {
        title: 'Calibration',
        route: "/calibration",
        icon: 'menu',
      },
      {
        title: 'RM/PM',
        icon: 'menu',
        preventNavigation: true,
        children: [
          {
            title: 'Material Status Label Printing',
            route: "/rm-pm",
            icon: 'subtitles'
          },
          {
            title: 'Material Staus Scanning',
            route: '/submenu1-2',
            icon: 'subtitles'
          },
          {
            title: 'TFR Doc Printing',
            route: "/rm-pm",
            icon: 'subtitles'
          },
          {
            title: 'TFR Doc Scanning',
            route: '/submenu1-2',
            icon: 'subtitles'
          },
          {
            title: 'Surplus Label',
            route: "/rm-pm",
            icon: 'subtitles'
          },
          {
            title: 'Surplus Approval',
            route: "/rm-pm",
            icon: 'subtitles'
          },
          {
            title: 'Tracking',
            route: "/rm-pm",
            icon: 'subtitles'
          },
          {
            title: 'Direct Status Label Printing',
            route: "/rm-pm",
            icon: 'subtitles'
          },
          {
            title: 'Blocking/UnBlocking Material',
            route: "/rm-pm",
            icon: 'subtitles'
          },
        ]
      },
      {
        title: 'Container Master',
        route: "/ContainerMaster",
        icon: 'menu'
      },
    ],
  
  
    'muthu': [
      {
        title: 'WM',
        icon: 'menu',
        preventNavigation: true,
        children: [
          {
            title: 'Pallatization',
            route: "/wm",
            icon: 'subtitles'
          },
          {
            title: 'Receipt Of Material',
            route: '/wm',
            icon: 'subtitles'
          },
          {
            title: 'Depallatization Individual Cont',
            route: "/wm",
            icon: 'subtitles'
          },
          {
            title: 'Remove Material From BIN',
            route: '/wm',
            icon: 'subtitles'
          },
          {
            title: 'Add Material to BIN',
            route: "/wm",
            icon: 'subtitles'
          },
          {
            title: 'Depallatization of Group Cont ',
            route: '/wm',
            icon: 'subtitles'
          },
          {
            title: 'Tracking',
            route: "/wm",
            icon: 'subtitles'
          },
        ]
      },
      {
        title: 'AQA',
        icon: 'menu',
        preventNavigation: true,
        children: [
          {
            title: 'TRF Document Scanning',
            route: "/aqa",
            icon: 'subtitles'
          },
          {
            title: 'Sampling Printing',
            route: "/aqa",
            icon: 'subtitles'
          },
          {
            title: 'sampling Scanning',
            route: "/aqa",
            icon: 'subtitles'
          },
          {
            title: 'Re-Sampling',
            route: "/aqa",
            icon: 'subtitles'
          },
          {
            title: 'Post To SAP',
            route: "/aqa",
            icon: 'subtitles'
          },
        ]
      },
      {
        title: 'WIP',
        route: "/wip",
        icon: 'menu'
      },
      {
        title: 'Finished Goods',
        route: "/FinishedGoods",
        icon: 'menu'
      },
  
    ]
  };
  
  get userSpecificMenuItems(): any[] {
    return this.menuItemsByUsername[this.username] || [];
  }
  
  toggleSubMenu(item: any): void {
    if (item.children) {
      item.expanded = !item.expanded;
    }
  }
  handleItemClick(event: MouseEvent, item: any) {
  if (item.preventNavigation) {
    event.preventDefault();
  }
  }
}





// import { Component } from '@angular/core';
// @Component({
//   selector: 'app-home',
//   templateUrl: './home.component.html',
//   styleUrls: ['./home.component.css']
// })
// export class HomeComponent {
//   title = 'materialProject';
//   menuItems: any[] = [
//     {
//       title: 'Inward Entry',
//       route: '/InwardEntry',
//       icon: 'menu',
//     },
//     {
//       title: 'RM/PM',
//       icon: 'menu',
//       preventNavigation: true,
//       children: [
//         {
//           title: 'Material Status Label Printing',
//           route: "/rm-pm",
//           icon: 'subtitles'
//         },
//         {
//           title: 'Material Staus Scanning',
//           route: '/submenu1-2',
//           icon: 'subtitles'
//         },
//         {
//           title: 'TFR Doc Printing',
//           route: "/rm-pm",
//           icon: 'subtitles'
//         },
//         {
//           title: 'TFR Doc Scanning',
//           route: '/submenu1-2',
//           icon: 'subtitles'
//         },
//         {
//           title: 'Surplus Label',
//           route: "/rm-pm",
//           icon: 'subtitles'
//         },
//         {
//           title: 'Surplus Approval',
//           route: "/rm-pm",
//           icon: 'subtitles'
//         },
//         {
//           title: 'Tracking',
//           route: "/rm-pm",
//           icon: 'subtitles'
//         },
//         {
//           title: 'Direct Status Label Printing',
//           route: "/rm-pm",
//           icon: 'subtitles'
//         },
//         {
//           title: 'Blocking/UnBlocking Material',
//           route: "/rm-pm",
//           icon: 'subtitles'
//         },
//       ]
//     },
//     {
//       title: 'WM',
//       icon: 'menu',
//       preventNavigation: true,
//       children: [
//         {
//           title: 'Pallatization',
//           route: "/wm",
//           icon: 'subtitles'
//         },
//         {
//           title: 'Receipt Of Material',
//           route: '/wm',
//           icon: 'subtitles'
//         },
//         {
//           title: 'Depallatization Individual Cont',
//           route: "/wm",
//           icon: 'subtitles'
//         },
//         {
//           title: 'Remove Material From BIN',
//           route: '/wm',
//           icon: 'subtitles'
//         },
//         {
//           title: 'Add Material to BIN',
//           route: "/wm",
//           icon: 'subtitles'
//         },
//         {
//           title: 'Depallatization of Group Cont ',
//           route: '/wm',
//           icon: 'subtitles'
//         },
//         {
//           title: 'Tracking',
//           route: "/wm",
//           icon: 'subtitles'
//         },
//       ]
//     },
//     {
//       title: 'AQA',
//       icon: 'menu',
//       preventNavigation: true,
//       children: [
//         {
//           title: 'TRF Document Scanning',
//           route: "/aqa",
//           icon: 'subtitles'
//         },
//         {
//           title: 'Sampling Printing',
//           route: "/aqa",
//           icon: 'subtitles'
//         },
//         {
//           title: 'sampling Scanning',
//           route: "/aqa",
//           icon: 'subtitles'
//         },
//         {
//           title: 'Re-Sampling',
//           route: "/aqa",
//           icon: 'subtitles'
//         },
//         {
//           title: 'Post To SAP',
//           route: "/aqa",
//           icon: 'subtitles'
//         },
//       ]
//     },
//     {
//       title: 'Dispensing',
//       icon: 'menu',
//       preventNavigation: true,
//       children: [
//         {
//           title: 'Material Picking',
//           route: "/dispensing",
//           icon: 'subtitles'
//         },
//         {
//           title: 'Picked Material Label Printing',
//           route: "/dispensing",
//           icon: 'subtitles'
//         },
//         {
//           title: 'Material Dispensing',
//           route: "/dispensing",
//           icon: 'subtitles'
//         },
//         {
//           title: 'Palletisation',
//           route: "/dispensing",
//           icon: 'subtitles'
//         },
//         {
//           title: 'Container Label Print',
//           route: "/dispensing",
//           icon: 'subtitles'
//         },
//         {
//           title: 'Loose Container',
//           route: "/dispensing",
//           icon: 'subtitles'
//         },
//         {
//           title: 'Post To Sap',
//           route: "/dispensing",
//           icon: 'subtitles'
//         },
//         {
//           title: 'Picking Cancellation',
//           route: "/dispensing",
//           icon: 'subtitles'
//         },
//         {
//           title: 'Miscellaneous Items',
//           route: "/dispensing",
//           icon: 'subtitles'
//         },
//         {
//           title: 'Quantity Adjustment',
//           route: "/dispensing",
//           icon: 'subtitles'
//         },
//       ]
//     },
//     {
//       title: 'Calibration',
//       route: "/calibration",
//       icon: 'menu',
//     },
//     {
//       title: 'WIP',
//       route: "/wip",
//       icon: 'menu'
//     },
//     {
//       title: 'Finished Goods',
//       route: "/FinishedGoods",
//       icon: 'menu'
//     },
//     {
//       title: 'Container Master',
//       route: "/ContainerMaster",
//       icon: 'menu'
//     },
//     {
//       title: 'Reprint',
//       route: "/Reprint",
//       icon: 'menu'
//     },
//     {
//       title: 'HDPE',
//       route: "/hdpe",
//       icon: 'menu'
//     },
//     {
//       title: 'Material Tracking',
//       route: "/materialTracking",
//       icon: 'menu'
//     }
//   ];
  
//   toggleSubMenu(item: any): void {
//     if (item.children) {
//       item.expanded = !item.expanded;
//     }
//   }
//   handleItemClick(event: MouseEvent, item: any) {
//   if (item.preventNavigation) {
//     event.preventDefault();
//   }
  
//   }
// }
