import { Component } from '@angular/core';
import { UserService } from 'src/app/components/user.service';

@Component({
  selector: 'app-material-tracking',
  templateUrl: './material-tracking.component.html',
  styleUrls: ['./material-tracking.component.css']
})
export class MaterialTrackingComponent {
  title = 'materialProject';
  username: string = ''; // Initialize the username variable

  constructor(private userService: UserService) { }

  ngOnInit(): void {
    // Fetch the username from the service or API call
    this.userService.getUsername().subscribe((username: string) => {
      this.username = username;
    });
  }

  menuItemsByUsername: { [key: string]: any[] } = {
    'vignesh': [
      {
        title: 'Inward Entry',
        route: '/InwardEntry',
        icon: 'menu',
      },
      // Add other menu items specific to 'vignesh'
    ],
    'naveen': [
      {
        title: 'RM/PM',
        icon: 'menu',
        preventNavigation: true,
        children: [
          // Add RM/PM menu items specific to 'naveen'
        ]
      },
      // Add other menu items specific to 'naveen'
    ],
    'muthu': [
      {
        title: 'new',
        icon: 'menu',
        preventNavigation: true,
        children: [
          // Add RM/PM menu items specific to 'muthu'
        ]
      },
      // Add other menu items specific to 'muthu'
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
