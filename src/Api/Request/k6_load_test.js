import http from 'k6/http';
import { sleep } from 'k6';

export let options={
    insecureSkipTLSVerify: true,
    notConnectionReuse: false,
    stages:[
        {duration: '5m', target: 100},
        {duration: '10m', target: 100},
        {duration: '5m', target: 0},
    ],
    thresholds: {
        http_req_duration: ['p(99)<150'], // 99% of requests must complete below 1.5s
    },
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