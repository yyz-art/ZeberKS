import hashlib, hmac, sys
from datetime import datetime

SECRET = b"XKJ-HX-ZEBER@2024!SECRET#KEY"

def generate_license(date_str: str) -> str:
    """生成授权码: ZC-{yyyMMdd}-{HMAC12}"""
    try:
        dt = datetime.strptime(date_str, "%Y-%m-%d")
        date_fmt = dt.strftime("%Y%m%d")
    except ValueError:
        date_fmt = date_str  # 尝试原样使用

    sig = hmac.new(SECRET, date_fmt.encode(), hashlib.sha256).hexdigest()[:12].upper()
    return f"ZC-{date_fmt}-{sig}"

if __name__ == "__main__":
    if len(sys.argv) < 2:
        print("用法: python gen_license.py <日期>")
        print("示例: python gen_license.py 2027-12-31")
        sys.exit(1)
    key = generate_license(sys.argv[1])
    print(key)
