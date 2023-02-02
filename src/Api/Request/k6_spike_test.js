import http from 'k6/http';
import { sleep } from 'k6';

export let options={
    insecureSkipTLSVerify: true,
    notConnectionReuse: false,
    stages:[
        {duration: '10s', target: 100},
        {duration: '1m', target: 100},
        {duration: '10s', target: 1500},
        {duration: '3m', target: 1500},
         {duration: '10s', target: 100},
         {duration: '3m', target: 100},
         {duration: '10s', target: 0},
    ],
}

export default function () {
  const url = 'http://localhost:5236/auth/login';
  const payload = JSON.stringify({
    "email": "email@email.com",
    "password": "password123",
  });

  const params = {
    headers: {
      'Content-Type': 'application/json',
    },
  };

// http.batch([
//   ['POST', url, payload, params],
//   ['GET', url, payload, params],
// ]);

  http.post(url, payload, params);
  sleep(1);
}