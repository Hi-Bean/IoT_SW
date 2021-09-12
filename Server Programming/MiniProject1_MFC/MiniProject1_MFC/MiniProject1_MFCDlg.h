
// MiniProject1_MFCDlg.h: 헤더 파일
//

#pragma once


// CMiniProject1MFCDlg 대화 상자
class CMiniProject1MFCDlg : public CDialogEx
{
	// 생성입니다.
public:
	CMiniProject1MFCDlg(CWnd* pParent = nullptr);	// 표준 생성자입니다.

// 대화 상자 데이터입니다.
#ifdef AFX_DESIGN_TIME
	enum { IDD = IDD_MINIPROJECT1_MFC_DIALOG };
#endif

protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV 지원입니다.


// 구현입니다.
protected:
	HICON m_hIcon;

	// 생성된 메시지 맵 함수
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	DECLARE_MESSAGE_MAP()
public:
	CEdit CMemo1;
	CFont m_Font;
	LOGFONT m_LogFont;
	afx_msg void OnSize(UINT nType, int cx, int cy);
	afx_msg void OnActivate(UINT nState, CWnd* pWndOther, BOOL bMinimized);
	afx_msg void OnMnuOpen();
	afx_msg void OnMnuSave();
	afx_msg void OnMnuExit();
	afx_msg void OnMnuNew();
	afx_msg void OnClose();
	void SaveFunction();
	afx_msg void OnMnuFont();
	afx_msg void OnMnuPage();
	afx_msg void OnMnuPrint();
	afx_msg void OnMnuFind();
	afx_msg void OnMnuReplace();
	afx_msg LRESULT OnFindReplace(WPARAM wParam, LPARAM lParam);
	afx_msg void On32795();
	afx_msg void OnMnuDate();
	afx_msg void OnMnuLower();
	afx_msg void OnMnuUpper();
	afx_msg void OnMnuTot();
};
