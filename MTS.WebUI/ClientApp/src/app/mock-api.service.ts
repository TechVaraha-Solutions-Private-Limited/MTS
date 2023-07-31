import { InMemoryDbService, RequestInfo, ResponseOptions } from 'angular-in-memory-web-api';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class MockApiService implements InMemoryDbService {
  createDb() {
    return {
      users: [
        { id: 1, username: 'naveen', password: 'nav@123' ,session:'15', plant:'ML24'},
        { id: 2, username: 'vignesh', password: 'vike@123',session:'15',plant:'ML11'},
        { id: 2, username: 'muthu', password: 'muthu@123',session:'15',plant:'ML22'},
      ],
    };
  }
  post(reqInfo: RequestInfo) {
    if (reqInfo.collectionName === 'users') {
      const { username, password ,plant } = reqInfo.utils.getJsonBody(reqInfo.req);

      const users = reqInfo.collection as any[];
      const user = users.find((u) => u.username === username && u.password === password  );

      if (user) {
        const responseOptions: ResponseOptions = {
          body: { message: 'Login successful!', token: 'TOKEN_VALUE' ,user:user.username},
          status: 200,
        };
        return reqInfo.utils.createResponse$(() => responseOptions);
      } else {
        const responseOptions: ResponseOptions = {
          body: { message: 'Invalid username or password.' },
          status: 401,
        };
        return reqInfo.utils.createResponse$(() => responseOptions);
      }
    }
    return undefined;
  }
}
