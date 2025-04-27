from http.server import SimpleHTTPRequestHandler, HTTPServer

class HelloHandler(SimpleHTTPRequestHandler):
    def do_GET(self):
        self.send_response(200)
        self.send_header('Content-type', 'text/html')
        self.end_headers()
        self.wfile.write(b'Hello, World!')

if __name__ == '__main__':
    server_address = ('0.0.0.0', 8000)
    httpd = HTTPServer(server_address, HelloHandler)
    print('Running server on port 8000...')
    httpd.serve_forever()

'''
docker login

docker build -t activity421 .

docker tag activity421 ivanhoan/activity421:latest
docker push ivanhoan/activity421:latest

docker pull ivanhoan/activity421:latest
docker run -p 8000:8000 ivanhoan/activity421
'''